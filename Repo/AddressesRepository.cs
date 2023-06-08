using ReportSystem.Context;
using ReportSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace ReportSystem.Repo
{
    public class AddressesRepository : IAddressesRepository
    {
        private readonly ReportSysContext reportSysContext;

        public AddressesRepository(ReportSysContext reportSysContext)
        {
            this.reportSysContext = reportSysContext;
        }

        public List<Districts> GetAllDistricts()
        {
            var districts = new List<Districts>
            {
            #region District #1
                new Districts
                {
                    DistrictsID = 1,
                    DistrictArName = "الرئيسي - عسفان طلاب",
                    DistrictEnName = "Main - Asfan Male"
                },
            #endregion

            #region District #2
                new Districts
                {
                    DistrictsID = 2,
                    DistrictArName = "الفيصلية طالبات",
                    DistrictEnName = "AL-Faisaliyah Female"
                },
            #endregion

            #region District #3
                new Districts
                {
                    DistrictsID = 3,
                    DistrictArName = "خليص ",
                    DistrictEnName = "Khulais"
                },
            #endregion

            #region District #4
                new Districts
                {
                    DistrictsID = 4,
                    DistrictArName = "الكامل",
                    DistrictEnName = "AL-Kamil"
                },
            #endregion

            #region District #5
                new Districts
                {
                    DistrictsID = 5,
                    DistrictArName = "الشرفية",
                    DistrictEnName = "AL-Sharafeyah"
                }
                #endregion
            };
            return districts;
        }

     

      
    }
}
