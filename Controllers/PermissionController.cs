using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReportSystem.Constants;
using ReportSystem.Helpers;
using ReportSystem.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Reflection;


namespace ReportSystem.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class PermissionController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public  PermissionController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }


        public async Task<List<RoleClaimsViewModel>> GetAllPermissions(string roleId)
        {          

            var allPermissions = new List<RoleClaimsViewModel>();
            var adminRole = await _roleManager.FindByNameAsync("SuperAdmin");       
            var allClaims = await _roleManager.GetClaimsAsync(adminRole);

            foreach (var claim in allClaims)
            {
                allPermissions.Add(new RoleClaimsViewModel
                {
                    Value = claim.Value.ToString(),
                    Type = claim.Type,
                });
            }            
            return allPermissions;
        }

        public async Task<ActionResult> Index(string roleId)
        {
            var model = new PermissionViewModel();
            var allPermissions = new List<RoleClaimsViewModel>();

            allPermissions.GetPermissions(typeof(Permissions.Report), roleId);
            allPermissions.GetPermissions(typeof(Permissions.Losts), roleId);
            allPermissions.GetPermissions(typeof(Permissions.LostCards), roleId);
            allPermissions.GetPermissions(typeof(Permissions.Delivery), roleId);
            
            //allPermissions = await GetAllPermissions(roleId);
            var role = await _roleManager.FindByIdAsync(roleId);
            model.RoleId = roleId;
            var claims = await _roleManager.GetClaimsAsync(role);
            var allClaimValues = allPermissions.Select(a => a.Value).ToList();
            var roleClaimValues = claims.Select(a => a.Value).ToList();
            var authorizedClaims = allClaimValues.Intersect(roleClaimValues).ToList();
            foreach (var permission in allPermissions)
            {
                if (authorizedClaims.Any(a => a == permission.Value))
                {
                    permission.Selected = true;
                }
            }
            model.RoleClaims = allPermissions;
            return View(model);
        }


        public async Task<IActionResult> Update(PermissionViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            var claims = await _roleManager.GetClaimsAsync(role);
            foreach (var claim in claims)
            {
                await _roleManager.RemoveClaimAsync(role, claim);
            }
            var selectedClaims = model.RoleClaims.Where(a => a.Selected).ToList();
            foreach (var claim in selectedClaims)
            {
                await _roleManager.AddPermissionClaim(role, claim.Value);
            }
            return RedirectToAction("Index", new { roleId = model.RoleId });
        }


        [HttpPost]
        public  async Task<IActionResult> AddPermission(string roleName , PermissionViewModel model)
        {
            if (roleName != null)
            {
                //await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
                var adminRole = await _roleManager.FindByNameAsync("SuperAdmin");
                //await _roleManager.AddPermissionClaim(adminRole, roleName.Trim());

                //await  AddPermissionClaim(adminRole, "Products");

                //var adminRole = await _roleManager.FindByNameAsync("SuperAdmin");
                //await _roleManager.AddPermissionClaim(adminRole, roleName.Trim());
                //IdentityRole role = new IdentityRole();
                var allClaims = await _roleManager.GetClaimsAsync(adminRole);
                var allPermissions = Permissions.GeneratePermissionsForModule(roleName.Trim());
                foreach (var permission in allPermissions)
                {
                    if (!allClaims.Any(a => a.Type == "Permission" && a.Value == permission))
                    {
                        await _roleManager.AddClaimAsync(adminRole, new Claim("Permission", permission));
                    }
                }

            }

            //return RedirectToAction("Index");
            return RedirectToAction("Index", new { roleId = model.RoleId });
        }

    
    }
}
