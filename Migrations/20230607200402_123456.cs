using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReportSystem.Migrations
{
    public partial class _123456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictArName = table.Column<string>(nullable: true),
                    DistrictEnName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictsID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: false),
                    JobID = table.Column<string>(maxLength: 50, nullable: false),
                    Employer = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Informers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameInformer = table.Column<string>(maxLength: 150, nullable: false),
                    NationalIdentificationId = table.Column<string>(maxLength: 50, nullable: false),
                    Phone_Number = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<int>(nullable: false),
                    RefNumber = table.Column<int>(nullable: false),
                    OldDate = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Payload = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ActoinDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    MainCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryEnName = table.Column<string>(nullable: true),
                    CategoryArName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.MainCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityEnName = table.Column<string>(nullable: true),
                    NationalityArName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityID);
                });

            migrationBuilder.CreateTable(
                name: "ProcedureReferences",
                columns: table => new
                {
                    ProcedureReferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Damages = table.Column<string>(nullable: false),
                    CreationUserName = table.Column<string>(nullable: true),
                    ExternalParty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedureReferences", x => x.ProcedureReferenceID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarType = table.Column<string>(maxLength: 50, nullable: false),
                    CarModel = table.Column<string>(maxLength: 50, nullable: false),
                    PlateNumber = table.Column<string>(maxLength: 50, nullable: false),
                    CarColor = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LostCardEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LostCardEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LostCardEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoriesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryEnName = table.Column<string>(nullable: true),
                    SubCategoryArName = table.Column<string>(nullable: true),
                    MainCategoriesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoriesID);
                    table.ForeignKey(
                        name: "FK_SubCategories_MainCategories_MainCategoriesID",
                        column: x => x.MainCategoriesID,
                        principalTable: "MainCategories",
                        principalColumn: "MainCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Losts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpenDate = table.Column<DateTime>(nullable: false),
                    OpenTime = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Job_UniversityID = table.Column<string>(nullable: true),
                    CollageName = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Stealing = table.Column<bool>(nullable: false),
                    StealingInfo = table.Column<string>(nullable: true),
                    LostDate = table.Column<DateTime>(nullable: false),
                    PlaceLost = table.Column<string>(nullable: true),
                    NationalitiesID = table.Column<int>(nullable: false),
                    InformerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Losts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Losts_Informers_InformerId",
                        column: x => x.InformerId,
                        principalTable: "Informers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Losts_Nationalities_NationalitiesID",
                        column: x => x.NationalitiesID,
                        principalTable: "Nationalities",
                        principalColumn: "NationalityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedureTypes",
                columns: table => new
                {
                    ProcedureTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcedureTypeName = table.Column<string>(nullable: false),
                    SubCategoriesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedureTypes", x => x.ProcedureTypeID);
                    table.ForeignKey(
                        name: "FK_ProcedureTypes_SubCategories_SubCategoriesID",
                        column: x => x.SubCategoriesID,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoriesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationReportDate = table.Column<DateTime>(nullable: false),
                    CreationReportTime = table.Column<DateTime>(nullable: false),
                    Entrance = table.Column<string>(nullable: true),
                    Bulding = table.Column<string>(nullable: true),
                    InformantID = table.Column<int>(nullable: true),
                    InformantName = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    ClosedDate = table.Column<DateTime>(nullable: false),
                    CreatorUserame = table.Column<string>(nullable: true),
                    AccidentCause = table.Column<string>(nullable: false),
                    LocationDescriptin = table.Column<string>(nullable: true),
                    ProcedureTypesId = table.Column<int>(nullable: false),
                    DistrictsID = table.Column<int>(nullable: false),
                    NationalitiesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_Report_Districts_DistrictsID",
                        column: x => x.DistrictsID,
                        principalTable: "Districts",
                        principalColumn: "DistrictsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Report_Nationalities_NationalitiesID",
                        column: x => x.NationalitiesID,
                        principalTable: "Nationalities",
                        principalColumn: "NationalityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Report_ProcedureTypes_ProcedureTypesId",
                        column: x => x.ProcedureTypesId,
                        principalTable: "ProcedureTypes",
                        principalColumn: "ProcedureTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProceduerRelations",
                columns: table => new
                {
                    PtocedureRelationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcedureDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ExternalParty = table.Column<string>(nullable: true),
                    ReportID = table.Column<int>(nullable: false),
                    ProcedureReferencesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProceduerRelations", x => x.PtocedureRelationID);
                    table.ForeignKey(
                        name: "FK_ProceduerRelations_ProcedureReferences_ProcedureReferencesID",
                        column: x => x.ProcedureReferencesID,
                        principalTable: "ProcedureReferences",
                        principalColumn: "ProcedureReferenceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProceduerRelations_Report_ReportID",
                        column: x => x.ReportID,
                        principalTable: "Report",
                        principalColumn: "ReportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleNumber = table.Column<string>(nullable: false),
                    VehicleLitter = table.Column<string>(nullable: false),
                    DriverName = table.Column<string>(nullable: false),
                    DriverAge = table.Column<int>(nullable: false),
                    ReffNumber = table.Column<string>(nullable: true),
                    VehicleDescription = table.Column<int>(nullable: false),
                    ReportID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
                    table.ForeignKey(
                        name: "FK_Vehicles_Report_ReportID",
                        column: x => x.ReportID,
                        principalTable: "Report",
                        principalColumn: "ReportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "DistrictsID", "DistrictArName", "DistrictEnName" },
                values: new object[,]
                {
                    { 1, "الرئيسي - عسفان طلاب", "Main - Asfan Male" },
                    { 2, "الفيصلية طالبات", "AL-Faisaliyah Female" },
                    { 3, "خليص ", "Khulais" },
                    { 4, "الكامل", "AL-Kamil" },
                    { 5, "الشرفية", "AL-Sharafeyah" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "MainCategoryID", "CategoryArName", "CategoryEnName" },
                values: new object[,]
                {
                    { 9, "سلامة عامة", "Public Safety" },
                    { 8, "صحة البيئة", "Environmental Health" },
                    { 7, "امني", "Security" },
                    { 5, "تلفيات", "Damages" },
                    { 6, "متنوعة", "Miscellaneous" },
                    { 3, "جنائية", "Criminal" },
                    { 2, "حريق", "Fire" },
                    { 1, "مرورية", "Traffic" },
                    { 4, "تسريبات", "Leaks" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "NationalityID", "NationalityArName", "NationalityEnName" },
                values: new object[,]
                {
                    { 10, "السودان", "Sudan" },
                    { 15, "البرازيل", "Brazil" },
                    { 14, "استراليا", "Australia" },
                    { 13, "افغانستان", "Afghanistan" },
                    { 12, "كندا", "Canada" },
                    { 11, "مصر", "Egypt" },
                    { 9, "روسيا", "Russia" },
                    { 2, "بريطانيا", "Britain" },
                    { 7, "ايطاليا", "Italy" },
                    { 6, "العراق", "Iraq" },
                    { 5, "اندونيسيا", "Indonesia" },
                    { 4, "الهند", "India" },
                    { 3, "امريكا", " The United States" },
                    { 16, "ماليزيا", "Malaysia" },
                    { 1, "المملكة العربية السعودية", " Saudi Arabia" },
                    { 8, "عمان", "Oman" },
                    { 17, "باكستان", "Pakistan" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoriesID", "MainCategoriesID", "SubCategoryArName", "SubCategoryEnName" },
                values: new object[,]
                {
                    { 1, 1, "انقلاب", "Rollover" },
                    { 70, 6, "أعطال، تلف ممتلكات", "Malfunctions, Property Damage" },
                    { 69, 6, "التزود بالوقود", "Refuleling" },
                    { 68, 6, "انقطاع مياه", "Water Cut" },
                    { 67, 6, "إزعاج", "Disturbance" },
                    { 48, 6, "وفاة طبيعية", "Natural Death" },
                    { 47, 6, "غرق", "Drowning" },
                    { 71, 6, "مبنى غير محكم الإغلاق", "Unsealed Building" },
                    { 46, 6, "تدريب خطط طوارئ", "Contingency Plans Training" },
                    { 44, 6, "عبث", "Messed Up" },
                    { 43, 6, "انقطاع التيار الكهربائي", "Power Outage" },
                    { 42, 6, "جرس إنذار سرقة", "Theft Alarm Bell" },
                    { 41, 6, "طلب نظافة", "Cleaning Request" },
                    { 40, 6, "طلب صيانة", "Maintenance Request" },
                    { 39, 6, "طلب مساندة", "Support Request" },
                    { 45, 6, "بلاغ كاذب", "Hoax" },
                    { 38, 6, "خدمات إسعافية", "Ambulance Services" },
                    { 72, 6, "(حيوان (إنقاذ، ضال، نافق", "Animal (Rescue, Lost, Dead)" },
                    { 50, 7, "ملاحظات أمنية", "Security Notes" },
                    { 64, 9, "ملاحظة سلامة", "Safety Note" },
                    { 63, 9, "إصابة عمل", "Work Injury" },
                    { 62, 8, "تلوث مواد غذائية", "Contamination of Foodstuffs" },
                    { 61, 8, "احتيال في أسعار", "Expensive Prices" },
                    { 60, 8, "مواد منتهية الصلاحية", "Expired Materials" },
                    { 59, 8, "تسمم", "Poisoning" },
                    { 49, 7, "أمني", "Security" },
                    { 58, 7, "درون", "Dron" },
                    { 56, 7, "إعتصام وإضراب", "Sit-and-Strike" },
                    { 55, 7, "إطلاق نار", "Shooting" },
                    { 54, 7, "خطف", "KSubCategoriesIDnapping" },
                    { 53, 7, "تفجير", "Detonation" },
                    { 52, 7, "احتجاز رهائن", "Hostage Taking" },
                    { 51, 7, "وجود متفجرات", "Presence of Explosives" },
                    { 57, 7, "تهديد أمني", "Security Threat" },
                    { 37, 6, "إبل سائبة", "Loose Camels" },
                    { 36, 6, "إنارة لاتعمل", "Broken Lighting" },
                    { 35, 6, "إشارة عطلانة", "Broken Traffic Signal" },
                    { 15, 2, "أشجار", "Trees" },
                    { 14, 2, "مركبات", "Vehicles" },
                    { 13, 2, "ممتلكات الجامعة", "Property of the Royal Commission" },
                    { 12, 2, "أخرى", "Other" },
                    { 11, 2, "حاويات", "Containers" },
                    { 10, 2, "مباني إدارية", "Government" },
                    { 16, 3, "مشاجرة", "Fight" },
                    { 9, 2, " مباني تجاري", "Commercial" },
                    { 7, 2, "سكني", "ResSubCategoriesIDential" },
                    { 6, 1, "وقوف خاطئ", "Wrong parking" },
                    { 5, 1, "أخرى مرورية", "Traffic other" },
                    { 4, 1, "مخالفة مرورية", "Traffic violations" },
                    { 3, 1, "دهس", "Run over" },
                    { 2, 1, "اصطدام", "Collision" },
                    { 8, 2, "مباني دراسية", "Industrial" },
                    { 17, 3, "سرقة", "Theft" },
                    { 18, 3, "اعتداء", "Assault" },
                    { 19, 3, "قتل", "Killing" },
                    { 34, 6, "جرس إنذار حريق", "Fire Alarm Bell" },
                    { 33, 6, "متنوعة", "Miscellaneous" },
                    { 32, 5, "تلفيات", "Damages" },
                    { 31, 4, "طفح صرف صحي", "Sewage Rash" },
                    { 30, 4, "مياه ري", "Irrigation Water" },
                    { 29, 4, "أخرى", "Other" },
                    { 28, 4, "مواد كيميائية", "Chemicals" },
                    { 27, 4, "مواد بترولية", "Petroleum Materials" },
                    { 26, 4, "مياه شرب", "Drinking Water" },
                    { 25, 4, "غاز", "Gas" },
                    { 24, 3, "عنف ", "Domestic violence" },
                    { 23, 3, "اشتباه", "Suspicion" },
                    { 22, 3, "أخرى", "Other" },
                    { 21, 3, " هروب", "Runaway maSubCategoriesID" },
                    { 20, 3, "انتحار", "SuicSubCategoriesIDe" },
                    { 65, 9, "التماس كهربائي", "Electrical Fault" },
                    { 66, 9, "مخالفة سلامة", "Safety Violation" }
                });

            migrationBuilder.InsertData(
                table: "ProcedureTypes",
                columns: new[] { "ProcedureTypeID", "ProcedureTypeName", "SubCategoriesID" },
                values: new object[,]
                {
                    { 1, "توجيه اقرب دورية", 1 },
                    { 113, "إبلاغ رئيس النوبة", 44 },
                    { 114, "توجيه التحقيق", 44 },
                    { 115, "اتباع الأولوية في الحدث حسب ما يتطلب", 44 },
                    { 116, "إبلاغ العمليات المشتركة", 46 },
                    { 117, "اتباع الأولوية في الحدث حسب ما يتطلب", 46 },
                    { 118, "إبلاغ حرس الحدود", 47 },
                    { 119, "رئيس النوبة", 47 },
                    { 120, "الإسعاف", 47 },
                    { 112, "اتباع الأولوية في الحدث حسب ما يتطلب", 43 },
                    { 121, "اتباع الأولوية في الحدث حسب ما يتطلب", 47 },
                    { 175, "إبلاغ إدارة المباني", 68 },
                    { 176, "إبلاغ إدراة النظافة", 72 },
                    { 123, "إبلاغ رئيس النوبة", 49 },
                    { 124, "الدوريات الأمنية", 49 },
                    { 125, "اتباع الأولوية في الحدث حسب ما يتطلب", 49 },
                    { 126, "إحاطة الاجهزة الامنية", 49 },
                    { 127, "إبلاغ رئيس النوبة", 50 },
                    { 128, "الدوريات الأمنية", 50 },
                    { 122, "إحاطة الاجهزة الامنية", 47 },
                    { 129, "اتباع الأولوية في الحدث حسب ما يتطلب", 50 },
                    { 111, "رئيس النوبة", 43 },
                    { 109, "إبلاغ إدارة النظافة", 41 },
                    { 91, "إبلاغ الدفاع المدني", 28 },
                    { 92, "مناوب السلامة", 28 },
                    { 93, "اتباع الأولوية في الحدث حسب ما يتطلب", 28 },
                    { 94, "إحاطة الاجهزة الامنية", 28 },
                    { 95, "اتخاذ الإجراء حسب ما يتطلب الحدث", 29 },
                    { 96, "إبلاغ الشركة المختصة", 30 },
                    { 97, "إبلاغ الشركة المختصة", 31 },
                    { 98, "يتم إبلاغ رئيس النوبة توجيه التحقيق الإدارة المختصة إتباع الأولية حسب في الحدث حسب ما يتطلب", 32 },
                    { 110, "إبلاغ شركة مرافق", 43 },
                    { 99, "إبلاغ الدفاع المدني", 34 },
                    { 101, "توجيه اقرب دورية للموقع", 35 },
                    { 102, "إبلاغ الشركة المختصة", 35 },
                    { 103, "إبلاغ الشركة المختصة", 36 },
                    { 104, "توجيه أقرب دورية للموقع", 37 },
                    { 105, "إبلاغ الإسعاف", 38 },
                    { 106, "إبلاغ رئيس النوبة", 39 },
                    { 107, "اتباع الأولوية في الحدث حسب ما يتطلب", 39 },
                    { 108, "إبلاغ الشركة المختصة في حال المنشأة خاصةالجامعة", 40 },
                    { 100, "فني الأجراس", 34 },
                    { 90, "الدفاع المدني", 28 },
                    { 130, "إبلاغ جهات الامنية", 51 },
                    { 132, "القيادة والسيطرة ببالجهات الامنية", 51 },
                    { 155, "إبلاغ الدوريات الأمنية", 56 },
                    { 156, "رئيس النوبة", 56 },
                    { 157, "العميات المشتركة", 56 },
                    { 158, "اتباع الأولوية في الحدث حسب ما يتطلب", 56 },
                    { 159, "إحاطة الاجهزة الامنية", 56 },
                    { 160, "إبلاغ القيادة والسيطرة بوزارة الداخلية", 57 },
                    { 161, "العميات المشتركة", 57 },
                    { 162, "الدوريات الأمنية", 57 },
                    { 154, "إحاطة الاجهزة الامنية", 55 },
                    { 163, "رئيس النوبة", 57 },
                    { 165, "إحاطة الاجهزة الامنية ", 57 },
                    { 166, "(إبلاغ المناوب (لرفع تقرير عن الحالة", 58 },
                    { 167, "(إبلاغ المناوب (لرفع تقرير عن الحالة", 59 },
                    { 168, "(إبلاغ المناوب (لرفع تقرير عن الحالة", 60 },
                    { 169, "(إبلاغ المناوب (لرفع تقرير عن الحالة", 61 },
                    { 170, "(إبلاغ المناوب (لرفع تقرير عن الحالة", 62 },
                    { 171, "يتم توجيه التحقيق", 63 },
                    { 172, "إبلاغ الشرطة في حال وجود إدعاء من قبل المصاب على المنشأة أو في حاله مدة الشفاء 15 يوم فأكثر أو في حال إدعاء المصاب", 63 },
                    { 164, "اتباع الأولوية في الحدث حسب ما يتطلب", 57 },
                    { 131, "الدفاع المدني", 51 },
                    { 153, "اتباع الأولوية في الحدث حسب ما يتطلب", 55 },
                    { 151, "رئيس النوبة", 55 },
                    { 133, "رئيس النوبة", 51 },
                    { 134, "اتباع الأولوية في الحدث حسب ما يتطلب", 51 },
                    { 135, "الدوريات الأمنية", 52 },
                    { 136, "رئيس النوبة", 52 },
                    { 137, "اتباع الأولوية في الحدث حسب ما يتطلب", 52 },
                    { 138, "إحاطة الاجهزة الامنية", 52 },
                    { 139, "الدوريات الأمنية", 53 },
                    { 140, "الدفاع المدني", 53 },
                    { 152, "الإسعاف", 55 },
                    { 141, "القيادة والسيطرة بالجهاز الامني", 53 },
                    { 143, "إبلاغ الدفاع المدني", 53 },
                    { 144, "رئيس النوبة", 53 },
                    { 145, "اتباع الأولوية في الحدث حسب ما يتطلب", 53 },
                    { 146, "إبلاغ الدوريات الأمنية", 54 },
                    { 147, "رئيس النوبة", 54 },
                    { 148, "اتباع الأولوية في الحدث حسب ما يتطلب", 54 },
                    { 149, "إحاطة الاجهزة الامنية", 54 },
                    { 150, "إبلاغ الدوريات الأمنية", 55 },
                    { 142, "الإسعاف", 53 },
                    { 89, "إبلاغ حماية البيئة", 28 },
                    { 88, "إحاطة الاجهزة الامنية", 27 },
                    { 87, "اتباع الأولوية في الحدث حسب ما يتطلب", 27 },
                    { 24, "رئيس النوبة", 8 },
                    { 25, "العمليات المشتركة", 8 },
                    { 26, "شركة الكهرباء", 8 },
                    { 27, "الإسعاف", 8 },
                    { 28, "التعميم في حال طلب المساندة", 8 },
                    { 29, "حماية البيئة", 8 },
                    { 30, " اتباع الأولوية في الحدث حسب ما يتطلب", 8 },
                    { 31, " إحاطة الاجهزة الامنية", 8 },
                    { 23, "إبلاغ الدفاع المدني", 8 },
                    { 32, "شركة الكهرباء", 9 },
                    { 34, "اتباع الأولوية في الحدث حسب ما يتطلب", 9 },
                    { 35, "إبلاغ الدفاع المدني", 10 },
                    { 36, "شركة الكهرباء", 10 },
                    { 37, "اتباع الأولية في الحدث حسب ما يتطلب", 10 },
                    { 38, "إبلاغ الدفاع المدني", 11 },
                    { 39, "إدارة النظافة", 11 },
                    { 40, "إبلاغ الدفاع المدني", 12 },
                    { 41, "اتباع الأولية في الحدث حسب ما يتطلب", 12 },
                    { 33, "إبلاغ الدفاع المدني", 9 },
                    { 42, "إبلاغ الدفاع المدني", 13 },
                    { 22, "إبلاغ الدفاع المدني", 8 },
                    { 20, "شركة الكهرباء", 7 },
                    { 2, "رئيس النوبة", 1 },
                    { 3, "إبلاغ الإسعاف", 1 },
                    { 4, "إبلاغ المرور", 1 },
                    { 5, "إبلاغ الدفاع المدني", 1 },
                    { 6, "يتم توجيه اقرب دوريه للموقع", 2 },
                    { 7, "إبلاغ الإسعاف في حال وجود اصابة", 2 },
                    { 8, "إبلاغ المرور في حال الاصابات او عدم حمل تأمين فيما عدا ذلك ابلاغ نجم", 2 },
                    { 9, "يتم توجيه التحقيق في حال وجود تلفيات ", 2 },
                    { 21, "اتباع الأولية في الحدث حسب ما يتطلب", 7 },
                    { 10, "يتم إبلاغ الدفاع المدني في حال الاحتجاز او حريق لاقدر الله وتطلب المساندة من الهلال الاحمر في حال وجود 3 إصابات او أكثر وأيضا الحالات الخطرة", 2 },
                    { 12, "رئيس النوبة", 3 },
                    { 13, "إبلاغ الإسعاف", 3 },
                    { 14, "إبلاغ المرور", 3 },
                    { 15, "إبلاغ الدفاع المدني", 3 },
                    { 16, "يتم توجيه أقرب دورية لموقع المخالفة", 4 },
                    { 17, " يتم إبلاغ رئيس النوبة وأخذ التوجيه المناسب", 5 },
                    { 18, "يتم توجيه أقرب دورية لموقع المخالفة", 6 },
                    { 19, "إبلاغ الدفاع المدني", 7 },
                    { 11, "توجيه اقرب دورية", 3 },
                    { 43, " إبلاغ رئيس النوبة", 13 },
                    { 44, "توجيه التحقيق", 13 },
                    { 45, "شركة الكهرباء", 13 },
                    { 69, "الإسعاف", 20 },
                    { 70, "توجيه أقرب دورية", 20 },
                    { 71, "اتباع الأولوية في الحدث حسب ما يتطلب", 20 },
                    { 72, "إحاطة الاجهزة الامنية", 20 },
                    { 73, "يتم إبلاغ المبلغ بإبلاغ الدوريات الأمنية أو التوجه للشرطة", 21 },
                    { 74, "إبلاغ الدوريات الأمنية", 23 },
                    { 75, "رئيس النوبة", 23 },
                    { 76, "توجيه أقرب دورية", 23 },
                    { 68, "رئيس النوبة", 20 },
                    { 77, "يتم إبلاغ رئيس النوبة ودورية المنطقة وإبلاغ الدوريات الأمنية", 24 },
                    { 79, "إبلاغ حماية البيئة", 25 },
                    { 80, "اتباع الأولوية في الحدث حسب ما يتطلب", 25 },
                    { 81, "إحاطة الاجهزة الامنية", 25 },
                    { 82, "إبلاغ الشركة المختصة", 26 },
                    { 83, "إبلاغ حماية البيئة", 27 },
                    { 84, "الدفاع المدني", 27 },
                    { 85, "إطفاء الهيئة الملكية", 27 },
                    { 86, "مناوب السلامة", 27 },
                    { 78, "إبلاغ الدفاع المدني", 25 },
                    { 67, "إبلاغ الدوريات الأمنية", 20 },
                    { 66, "إحاطة الاجهزة الامنية", 19 },
                    { 65, "اتباع الأولوية في الحدث حسب ما يتطلب", 19 },
                    { 46, "إبلاغ الدفاع المدني في حال المساندة", 13 },
                    { 47, "إبلاغ الإسعاف", 13 },
                    { 48, "إحاطة الاجهزة الامنية", 13 },
                    { 49, "يتم توجيه أقرب دورية للموقع ويطلب الدفاع المدني في حال المساندة", 14 },
                    { 50, "الإسعاف", 14 },
                    { 51, "إبلاغ الدوريات الأمنية", 16 },
                    { 52, "رئيس النوبة", 16 },
                    { 53, "توجيه أقرب دورية", 16 },
                    { 54, "اتباع الأولوية في الحدث حسب ما يتطلب", 16 },
                    { 55, "في حال السرقة أو المفقودات كانت بأحد منشآت الجامعة يتم توجيه التحقيق وإبلاغ رئيس النوبة", 17 },
                    { 56, "إحاطة الاجهزة الامنية إذا كانت السرقة خاصة ", 17 },
                    { 57, "إبلاغ الدوريات الأمنية", 18 },
                    { 58, "رئيس النوبة", 18 },
                    { 59, "الإسعاف", 18 },
                    { 60, "اتباع الأولوية في الحدث حسب ما يتطلب", 18 },
                    { 61, "إبلاغ الدوريات الأمنية", 19 },
                    { 62, "رئيس النوبة", 19 },
                    { 63, "الإسعاف", 19 },
                    { 64, "توجيه أقرب دورية", 19 },
                    { 173, "توجيه مناوب السلامة", 64 },
                    { 174, "توجيه مناوب السلامة", 65 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_EmployeeId",
                table: "Deliveries",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LostCardEmployees_EmployeeId",
                table: "LostCardEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Losts_InformerId",
                table: "Losts",
                column: "InformerId");

            migrationBuilder.CreateIndex(
                name: "IX_Losts_NationalitiesID",
                table: "Losts",
                column: "NationalitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_ProceduerRelations_ProcedureReferencesID",
                table: "ProceduerRelations",
                column: "ProcedureReferencesID");

            migrationBuilder.CreateIndex(
                name: "IX_ProceduerRelations_ReportID",
                table: "ProceduerRelations",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedureTypes_SubCategoriesID",
                table: "ProcedureTypes",
                column: "SubCategoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_DistrictsID",
                table: "Report",
                column: "DistrictsID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_NationalitiesID",
                table: "Report",
                column: "NationalitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ProcedureTypesId",
                table: "Report",
                column: "ProcedureTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoriesID",
                table: "SubCategories",
                column: "MainCategoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ReportID",
                table: "Vehicles",
                column: "ReportID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "LostCardEmployees");

            migrationBuilder.DropTable(
                name: "Losts");

            migrationBuilder.DropTable(
                name: "ProceduerRelations");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Informers");

            migrationBuilder.DropTable(
                name: "ProcedureReferences");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "ProcedureTypes");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
