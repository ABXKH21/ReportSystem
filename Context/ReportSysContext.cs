using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReportSystem.Models;

namespace ReportSystem.Context
{
    //public class ReportSysContext : DbContext
    public class ReportSysContext : IdentityDbContext
    {
        public ReportSysContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);



            builder.Entity<Nationalities>().HasData(
            #region Nationality 1
                new Nationalities
                {
                    NationalityID = 1,
                    NationalityEnName = " Saudi Arabia",
                    NationalityArName = "المملكة العربية السعودية"
                },
            #endregion

            #region Nationality 2
                new Nationalities
                {
                    NationalityID = 2,
                    NationalityEnName = "Britain",
                    NationalityArName = "بريطانيا"
                },
            #endregion

            #region Nationality 3
                new Nationalities
                {
                    NationalityID = 3,
                    NationalityEnName = " The United States",
                    NationalityArName = "امريكا"
                },
            #endregion

            #region Nationality 4
                new Nationalities
                {
                    NationalityID = 4,
                    NationalityEnName = "India",
                    NationalityArName = "الهند"
                },
            #endregion

            #region Nationality 5
                new Nationalities
                {
                    NationalityID = 5,
                    NationalityEnName = "Indonesia",
                    NationalityArName = "اندونيسيا"
                },
            #endregion

            #region Nationality 6
                new Nationalities
                {
                    NationalityID = 6,
                    NationalityEnName = "Iraq",
                    NationalityArName = "العراق"
                },
            #endregion

            #region Nationality 7
                new Nationalities
                {
                    NationalityID = 7,
                    NationalityEnName = "Italy",
                    NationalityArName = "ايطاليا"
                },
            #endregion

            #region Nationality 8
                new Nationalities
                {
                    NationalityID = 8,
                    NationalityEnName = "Oman",
                    NationalityArName = "عمان"
                },
            #endregion

            #region Nationality 9
                new Nationalities
                {
                    NationalityID = 9,
                    NationalityEnName = "Russia",
                    NationalityArName = "روسيا"
                },
            #endregion

            #region Nationality 10
                new Nationalities
                {
                    NationalityID = 10,
                    NationalityEnName = "Sudan",
                    NationalityArName = "السودان"
                },
            #endregion

            #region Nationality 11
                new Nationalities
                {
                    NationalityID = 11,
                    NationalityEnName = "Egypt",
                    NationalityArName = "مصر"
                },
            #endregion

            #region Nationality 12
                new Nationalities
                {
                    NationalityID = 12,
                    NationalityEnName = "Canada",
                    NationalityArName = "كندا"
                },
            #endregion

            #region Nationality 13
                new Nationalities
                {
                    NationalityID = 13,
                    NationalityEnName = "Afghanistan",
                    NationalityArName = "افغانستان"
                },
            #endregion

            #region Nationality 14
                new Nationalities
                {
                    NationalityID = 14,
                    NationalityEnName = "Australia",
                    NationalityArName = "استراليا"
                },
            #endregion

            #region Nationality 15
                new Nationalities
                {
                    NationalityID = 15,
                    NationalityEnName = "Brazil",
                    NationalityArName = "البرازيل"
                },
            #endregion

            #region Nationality 16
                new Nationalities
                {
                    NationalityID = 16,
                    NationalityEnName = "Malaysia",
                    NationalityArName = "ماليزيا"
                },
            #endregion

            #region Nationality 17
                new Nationalities
                {
                    NationalityID = 17,
                    NationalityEnName = "Pakistan",
                    NationalityArName = "باكستان"
                }
                #endregion
                );


            builder.Entity<MainCategories>().HasData(

            #region Main Category 1
                new MainCategories
                {
                    MainCategoryID = 1,
                    CategoryEnName = "Traffic",
                    CategoryArName = "مرورية"
                },
            #endregion

            #region Main Category 2
                new MainCategories
                {
                    MainCategoryID = 2,
                    CategoryEnName = "Fire",
                    CategoryArName = "حريق"
                },
            #endregion

            #region Main Category 3
                new MainCategories
                {
                    MainCategoryID = 3,
                    CategoryEnName = "Criminal",
                    CategoryArName = "جنائية"
                },
            #endregion

            #region Main Category 4
                new MainCategories
                {
                    MainCategoryID = 4,
                    CategoryEnName = "Leaks",
                    CategoryArName = "تسريبات"
                },
            #endregion

            #region Main Category 5
                new MainCategories
                {
                    MainCategoryID = 5,
                    CategoryEnName = "Damages",
                    CategoryArName = "تلفيات"
                },
            #endregion

            #region Main Category 6
                new MainCategories
                {
                    MainCategoryID = 6,
                    CategoryEnName = "Miscellaneous",
                    CategoryArName = "متنوعة"
                },
            #endregion

            #region Main Category 7
                new MainCategories
                {
                    MainCategoryID = 7,
                    CategoryEnName = "Security",
                    CategoryArName = "امني"
                },
            #endregion

            #region Main Category 8
                new MainCategories
                {
                    MainCategoryID = 8,
                    CategoryEnName = "Environmental Health",
                    CategoryArName = "صحة البيئة"
                },
            #endregion

            #region Main Category 9
                new MainCategories
                {
                    MainCategoryID = 9,
                    CategoryEnName = "Public Safety",
                    CategoryArName = "سلامة عامة"
                }
                #endregion
              );


            builder.Entity<SubCategories>().HasData(

            #region Releated to Main Category 1
                new SubCategories
                {
                    SubCategoriesID = 1,
                    SubCategoryEnName = "Rollover",
                    SubCategoryArName = "انقلاب",
                    MainCategoriesID = 1
                },
                new SubCategories
                {
                    SubCategoriesID = 2,
                    SubCategoryEnName = "Collision",
                    SubCategoryArName = "اصطدام",
                    MainCategoriesID = 1
                },
                new SubCategories
                {
                    SubCategoriesID = 3,
                    SubCategoryEnName = "Run over",
                    SubCategoryArName = "دهس",
                    MainCategoriesID = 1
                },
                new SubCategories
                {
                    SubCategoriesID = 4,
                    SubCategoryEnName = "Traffic violations",
                    SubCategoryArName = "مخالفة مرورية",
                    MainCategoriesID = 1
                },
                new SubCategories
                {
                    SubCategoriesID = 5,
                    SubCategoryEnName = "Traffic other",
                    SubCategoryArName = "أخرى مرورية",
                    MainCategoriesID = 1
                },
                new SubCategories
                {
                    SubCategoriesID = 6,
                    SubCategoryEnName = "Wrong parking",
                    SubCategoryArName = "وقوف خاطئ",
                    MainCategoriesID = 1
                },
            #endregion

            #region Releated to Main Category 2
                new SubCategories
                {
                    SubCategoriesID = 7,
                    SubCategoryEnName = "ResSubCategoriesIDential",
                    SubCategoryArName = "سكني",
                    MainCategoriesID = 2
                },
                new SubCategories
                {
                    SubCategoriesID = 8,
                    SubCategoryEnName = "Industrial",
                    SubCategoryArName = "مباني دراسية",
                    MainCategoriesID = 2
                },
                new SubCategories
                {
                    SubCategoriesID = 9,
                    SubCategoryEnName = "Commercial",
                    SubCategoryArName = " مباني تجاري",
                    MainCategoriesID = 2
                },
                new SubCategories
                {
                    SubCategoriesID = 10,
                    SubCategoryEnName = "Government",
                    SubCategoryArName = "مباني إدارية",
                    MainCategoriesID = 2
                },
                new SubCategories
                {
                    SubCategoriesID = 11,
                    SubCategoryEnName = "Containers",
                    SubCategoryArName = "حاويات",
                    MainCategoriesID = 2
                },
                new SubCategories
                {
                    SubCategoriesID = 12,
                    SubCategoryEnName = "Other",
                    SubCategoryArName = "أخرى",
                    MainCategoriesID = 2
                },
                new SubCategories
                {
                    SubCategoriesID = 13,
                    SubCategoryEnName = "Property of the Royal Commission",
                    SubCategoryArName = "ممتلكات الجامعة",
                    MainCategoriesID = 2
                },
                new SubCategories
                {
                    SubCategoriesID = 14,
                    SubCategoryEnName = "Vehicles",
                    SubCategoryArName = "مركبات",
                    MainCategoriesID = 2
                },
                new SubCategories
                {
                    SubCategoriesID = 15,
                    SubCategoryEnName = "Trees",
                    SubCategoryArName = "أشجار",
                    MainCategoriesID = 2
                },
            #endregion

            #region Releated to Main Category 3
                new SubCategories
                {
                    SubCategoriesID = 16,
                    SubCategoryEnName = "Fight",
                    SubCategoryArName = "مشاجرة",
                    MainCategoriesID = 3
                },
                new SubCategories
                {
                    SubCategoriesID = 17,
                    SubCategoryEnName = "Theft",
                    SubCategoryArName = "سرقة",
                    MainCategoriesID = 3
                },
                new SubCategories
                {
                    SubCategoriesID = 18,
                    SubCategoryEnName = "Assault",
                    SubCategoryArName = "اعتداء",
                    MainCategoriesID = 3
                },
                new SubCategories
                {
                    SubCategoriesID = 19,
                    SubCategoryEnName = "Killing",
                    SubCategoryArName = "قتل",
                    MainCategoriesID = 3
                },
                new SubCategories
                {
                    SubCategoriesID = 20,
                    SubCategoryEnName = "SuicSubCategoriesIDe",
                    SubCategoryArName = "انتحار",
                    MainCategoriesID = 3
                },
                new SubCategories
                {
                    SubCategoriesID = 21,
                    SubCategoryEnName = "Runaway maSubCategoriesID",
                    SubCategoryArName = " هروب",
                    MainCategoriesID = 3
                },
                new SubCategories
                {
                    SubCategoriesID = 22,
                    SubCategoryEnName = "Other",
                    SubCategoryArName = "أخرى",
                    MainCategoriesID = 3
                },
                new SubCategories
                {
                    SubCategoriesID = 23,
                    SubCategoryEnName = "Suspicion",
                    SubCategoryArName = "اشتباه",
                    MainCategoriesID = 3
                },
                new SubCategories
                {
                    SubCategoriesID = 24,
                    SubCategoryEnName = "Domestic violence",
                    SubCategoryArName = "عنف ",
                    MainCategoriesID = 3
                },
            #endregion

            #region Releated to Main Category 4
                new SubCategories
                {
                    SubCategoriesID = 25,
                    SubCategoryEnName = "Gas",
                    SubCategoryArName = "غاز",
                    MainCategoriesID = 4
                },
                new SubCategories
                {
                    SubCategoriesID = 26,
                    SubCategoryEnName = "Drinking Water",
                    SubCategoryArName = "مياه شرب",
                    MainCategoriesID = 4
                },
                new SubCategories
                {
                    SubCategoriesID = 27,
                    SubCategoryEnName = "Petroleum Materials",
                    SubCategoryArName = "مواد بترولية",
                    MainCategoriesID = 4
                },
                new SubCategories
                {
                    SubCategoriesID = 28,
                    SubCategoryEnName = "Chemicals",
                    SubCategoryArName = "مواد كيميائية",
                    MainCategoriesID = 4
                },
                new SubCategories
                {
                    SubCategoriesID = 29,
                    SubCategoryEnName = "Other",
                    SubCategoryArName = "أخرى",
                    MainCategoriesID = 4
                },
                new SubCategories
                {
                    SubCategoriesID = 30,
                    SubCategoryEnName = "Irrigation Water",
                    SubCategoryArName = "مياه ري",
                    MainCategoriesID = 4
                },
                new SubCategories
                {
                    SubCategoriesID = 31,
                    SubCategoryEnName = "Sewage Rash",
                    SubCategoryArName = "طفح صرف صحي",
                    MainCategoriesID = 4
                },
            #endregion

            #region Releated to Main Category 5
                new SubCategories
                {
                    SubCategoriesID = 32,
                    SubCategoryEnName = "Damages",
                    SubCategoryArName = "تلفيات",
                    MainCategoriesID = 5
                },
            #endregion

            #region Releated to Main Category 6
                new SubCategories
                {
                    SubCategoriesID = 33,
                    SubCategoryEnName = "Miscellaneous",
                    SubCategoryArName = "متنوعة",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 34,
                    SubCategoryEnName = "Fire Alarm Bell",
                    SubCategoryArName = "جرس إنذار حريق",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 35,
                    SubCategoryEnName = "Broken Traffic Signal",
                    SubCategoryArName = "إشارة عطلانة",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 36,
                    SubCategoryEnName = "Broken Lighting",
                    SubCategoryArName = "إنارة لاتعمل",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 37,
                    SubCategoryEnName = "Loose Camels",
                    SubCategoryArName = "إبل سائبة",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 38,
                    SubCategoryEnName = "Ambulance Services",
                    SubCategoryArName = "خدمات إسعافية",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 39,
                    SubCategoryEnName = "Support Request",
                    SubCategoryArName = "طلب مساندة",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 40,
                    SubCategoryEnName = "Maintenance Request",
                    SubCategoryArName = "طلب صيانة",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 41,
                    SubCategoryEnName = "Cleaning Request",
                    SubCategoryArName = "طلب نظافة",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 42,
                    SubCategoryEnName = "Theft Alarm Bell",
                    SubCategoryArName = "جرس إنذار سرقة",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 43,
                    SubCategoryEnName = "Power Outage",
                    SubCategoryArName = "انقطاع التيار الكهربائي",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 44,
                    SubCategoryEnName = "Messed Up",
                    SubCategoryArName = "عبث",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 45,
                    SubCategoryEnName = "Hoax",
                    SubCategoryArName = "بلاغ كاذب",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 46,
                    SubCategoryEnName = "Contingency Plans Training",
                    SubCategoryArName = "تدريب خطط طوارئ",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 47,
                    SubCategoryEnName = "Drowning",
                    SubCategoryArName = "غرق",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 48,
                    SubCategoryEnName = "Natural Death",
                    SubCategoryArName = "وفاة طبيعية",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 67,
                    SubCategoryEnName = "Disturbance",
                    SubCategoryArName = "إزعاج",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 68,
                    SubCategoryEnName = "Water Cut",
                    SubCategoryArName = "انقطاع مياه",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 69,
                    SubCategoryEnName = "Refuleling",
                    SubCategoryArName = "التزود بالوقود",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 70,
                    SubCategoryEnName = "Malfunctions, Property Damage",
                    SubCategoryArName = "أعطال، تلف ممتلكات",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 71,
                    SubCategoryEnName = "Unsealed Building",
                    SubCategoryArName = "مبنى غير محكم الإغلاق",
                    MainCategoriesID = 6
                },
                new SubCategories
                {
                    SubCategoriesID = 72,
                    SubCategoryEnName = "Animal (Rescue, Lost, Dead)",
                    SubCategoryArName = "(حيوان (إنقاذ، ضال، نافق",
                    MainCategoriesID = 6
                },
            #endregion

            #region Releated to Main Category 7
                new SubCategories
                {
                    SubCategoriesID = 49,
                    SubCategoryEnName = "Security",
                    SubCategoryArName = "أمني",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 50,
                    SubCategoryEnName = "Security Notes",
                    SubCategoryArName = "ملاحظات أمنية",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 51,
                    SubCategoryEnName = "Presence of Explosives",
                    SubCategoryArName = "وجود متفجرات",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 52,
                    SubCategoryEnName = "Hostage Taking",
                    SubCategoryArName = "احتجاز رهائن",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 53,
                    SubCategoryEnName = "Detonation",
                    SubCategoryArName = "تفجير",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 54,
                    SubCategoryEnName = "KSubCategoriesIDnapping",
                    SubCategoryArName = "خطف",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 55,
                    SubCategoryEnName = "Shooting",
                    SubCategoryArName = "إطلاق نار",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 56,
                    SubCategoryEnName = "Sit-and-Strike",
                    SubCategoryArName = "إعتصام وإضراب",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 57,
                    SubCategoryEnName = "Security Threat",
                    SubCategoryArName = "تهديد أمني",
                    MainCategoriesID = 7
                },
                new SubCategories
                {
                    SubCategoriesID = 58,
                    SubCategoryEnName = "Dron",
                    SubCategoryArName = "درون",
                    MainCategoriesID = 7
                },
            #endregion

            #region Releated to Main Category 8
                new SubCategories
                {
                    SubCategoriesID = 59,
                    SubCategoryEnName = "Poisoning",
                    SubCategoryArName = "تسمم",
                    MainCategoriesID = 8
                },
                new SubCategories
                {
                    SubCategoriesID = 60,
                    SubCategoryEnName = "Expired Materials",
                    SubCategoryArName = "مواد منتهية الصلاحية",
                    MainCategoriesID = 8
                },
                new SubCategories
                {
                    SubCategoriesID = 61,
                    SubCategoryEnName = "Expensive Prices",
                    SubCategoryArName = "احتيال في أسعار",
                    MainCategoriesID = 8
                },
                new SubCategories
                {
                    SubCategoriesID = 62,
                    SubCategoryEnName = "Contamination of Foodstuffs",
                    SubCategoryArName = "تلوث مواد غذائية",
                    MainCategoriesID = 8
                },
            #endregion

            #region Releated to Main Category 9
                new SubCategories
                {
                    SubCategoriesID = 63,
                    SubCategoryEnName = "Work Injury",
                    SubCategoryArName = "إصابة عمل",
                    MainCategoriesID = 9
                },
                new SubCategories
                {
                    SubCategoriesID = 64,
                    SubCategoryEnName = "Safety Note",
                    SubCategoryArName = "ملاحظة سلامة",
                    MainCategoriesID = 9
                },
                new SubCategories
                {
                    SubCategoriesID = 65,
                    SubCategoryEnName = "Electrical Fault",
                    SubCategoryArName = "التماس كهربائي",
                    MainCategoriesID = 9
                },
                new SubCategories
                {
                    SubCategoriesID = 66,
                    SubCategoryEnName = "Safety Violation",
                    SubCategoryArName = "مخالفة سلامة",
                    MainCategoriesID = 9
                }
                #endregion

                );

            builder.Entity<ProcedureTypes>().HasData(

            #region Releated to Sub Category 1
                new ProcedureTypes
                {
                    ProcedureTypeID = 1,
                    ProcedureTypeName = "توجيه اقرب دورية",
                    SubCategoriesID = 1
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 2,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 1
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 3,
                    ProcedureTypeName = "إبلاغ الإسعاف",
                    SubCategoriesID = 1
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 4,
                    ProcedureTypeName = "إبلاغ المرور",
                    SubCategoriesID = 1
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 5,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 1
                },
            #endregion

            #region Releated to Sub Category 2
                new ProcedureTypes
                {
                    ProcedureTypeID = 6,
                    ProcedureTypeName = "يتم توجيه اقرب دوريه للموقع",
                    SubCategoriesID = 2
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 7,
                    ProcedureTypeName = "إبلاغ الإسعاف في حال وجود اصابة",
                    SubCategoriesID = 2
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 8,
                    ProcedureTypeName = "إبلاغ المرور في حال الاصابات او عدم حمل تأمين فيما عدا ذلك ابلاغ نجم",
                    SubCategoriesID = 2
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 9,
                    ProcedureTypeName = "يتم توجيه التحقيق في حال وجود تلفيات ",
                    SubCategoriesID = 2
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 10,
                    ProcedureTypeName = "يتم إبلاغ الدفاع المدني في حال الاحتجاز او حريق لاقدر الله وتطلب المساندة من الهلال الاحمر في حال وجود 3 إصابات او أكثر وأيضا الحالات الخطرة",
                    SubCategoriesID = 2
                },
            #endregion

            #region Releated to Sub Category 3
                new ProcedureTypes
                {
                    ProcedureTypeID = 11,
                    ProcedureTypeName = "توجيه اقرب دورية",
                    SubCategoriesID = 3
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 12,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 3
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 13,
                    ProcedureTypeName = "إبلاغ الإسعاف",
                    SubCategoriesID = 3
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 14,
                    ProcedureTypeName = "إبلاغ المرور",
                    SubCategoriesID = 3
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 15,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 3
                },
            #endregion

            #region Releated to Sub Category 4
                new ProcedureTypes
                {
                    ProcedureTypeID = 16,
                    ProcedureTypeName = "يتم توجيه أقرب دورية لموقع المخالفة",
                    SubCategoriesID = 4
                },
            #endregion

            #region Releated to Sub Category 5
                new ProcedureTypes
                {
                    ProcedureTypeID = 17,
                    ProcedureTypeName = " يتم إبلاغ رئيس النوبة وأخذ التوجيه المناسب",
                    SubCategoriesID = 5
                },
            #endregion

            #region Releated to Sub Category 6
                new ProcedureTypes
                {
                    ProcedureTypeID = 18,
                    ProcedureTypeName = "يتم توجيه أقرب دورية لموقع المخالفة",
                    SubCategoriesID = 6
                },
            #endregion

            #region Releated to Sub Category 7
                new ProcedureTypes
                {
                    ProcedureTypeID = 19,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 7
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 20,
                    ProcedureTypeName = "شركة الكهرباء",
                    SubCategoriesID = 7
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 21,
                    ProcedureTypeName = "اتباع الأولية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 7
                },
            #endregion

            #region Releated to Sub Category 8
                new ProcedureTypes
                {
                    ProcedureTypeID = 22,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 23,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 24,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 25,
                    ProcedureTypeName = "العمليات المشتركة",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 26,
                    ProcedureTypeName = "شركة الكهرباء",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 27,
                    ProcedureTypeName = "الإسعاف",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 28,
                    ProcedureTypeName = "التعميم في حال طلب المساندة",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 29,
                    ProcedureTypeName = "حماية البيئة",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 30,
                    ProcedureTypeName = " اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 8
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 31,
                    ProcedureTypeName = " إحاطة الاجهزة الامنية",
                    SubCategoriesID = 8
                },
            #endregion

            #region Releated to Sub Category 9
                new ProcedureTypes
                {
                    ProcedureTypeID = 32,
                    ProcedureTypeName = "شركة الكهرباء",
                    SubCategoriesID = 9
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 33,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 9
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 34,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 9
                },
            #endregion

            #region Releated to Sub Category 10
                new ProcedureTypes
                {
                    ProcedureTypeID = 35,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 10
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 36,
                    ProcedureTypeName = "شركة الكهرباء",
                    SubCategoriesID = 10
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 37,
                    ProcedureTypeName = "اتباع الأولية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 10
                },
            #endregion

            #region Releated to Sub Category 11
                new ProcedureTypes
                {
                    ProcedureTypeID = 38,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 11
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 39,
                    ProcedureTypeName = "إدارة النظافة",
                    SubCategoriesID = 11
                },
            #endregion

            #region Releated to Sub Category 12
                new ProcedureTypes
                {
                    ProcedureTypeID = 40,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 12
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 41,
                    ProcedureTypeName = "اتباع الأولية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 12
                },
            #endregion

            #region Releated to Sub Category 13
                new ProcedureTypes
                {
                    ProcedureTypeID = 42,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 13
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 43,
                    ProcedureTypeName = " إبلاغ رئيس النوبة",
                    SubCategoriesID = 13
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 44,
                    ProcedureTypeName = "توجيه التحقيق",
                    SubCategoriesID = 13
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 45,
                    ProcedureTypeName = "شركة الكهرباء",
                    SubCategoriesID = 13
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 46,
                    ProcedureTypeName = "إبلاغ الدفاع المدني في حال المساندة",
                    SubCategoriesID = 13
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 47,
                    ProcedureTypeName = "إبلاغ الإسعاف",
                    SubCategoriesID = 13
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 48,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 13
                },
            #endregion

            #region Releated to Sub Category 14
                new ProcedureTypes
                {
                    ProcedureTypeID = 49,
                    ProcedureTypeName = "يتم توجيه أقرب دورية للموقع ويطلب الدفاع المدني في حال المساندة",
                    SubCategoriesID = 14
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 50,
                    ProcedureTypeName = "الإسعاف",
                    SubCategoriesID = 14
                },
            #endregion

            #region Releated to Sub Category 15
                //لا يوجد إجراءات بخصوص الأشجار في بلاغات الحرائق - دليل البلاغات
            #endregion

            #region Releated to Sub Category 16
                new ProcedureTypes
                {
                    ProcedureTypeID = 51,
                    ProcedureTypeName = "إبلاغ الدوريات الأمنية",
                    SubCategoriesID = 16
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 52,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 16
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 53,
                    ProcedureTypeName = "توجيه أقرب دورية",
                    SubCategoriesID = 16
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 54,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 16
                },
            #endregion

            #region Releated to Sub Category 17
                new ProcedureTypes
                {
                    ProcedureTypeID = 55,
                    ProcedureTypeName = "في حال السرقة أو المفقودات كانت بأحد منشآت الجامعة يتم توجيه التحقيق وإبلاغ رئيس النوبة",
                    SubCategoriesID = 17
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 56,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية إذا كانت السرقة خاصة ",
                    SubCategoriesID = 17
                },
            #endregion

            #region Releated to Sub Category 18
                new ProcedureTypes
                {
                    ProcedureTypeID = 57,
                    ProcedureTypeName = "إبلاغ الدوريات الأمنية",
                    SubCategoriesID = 18
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 58,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 18
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 59,
                    ProcedureTypeName = "الإسعاف",
                    SubCategoriesID = 18
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 60,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 18
                },
            #endregion

            #region Releated to Sub Category 19
                new ProcedureTypes
                {
                    ProcedureTypeID = 61,
                    ProcedureTypeName = "إبلاغ الدوريات الأمنية",
                    SubCategoriesID = 19
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 62,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 19
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 63,
                    ProcedureTypeName = "الإسعاف",
                    SubCategoriesID = 19
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 64,
                    ProcedureTypeName = "توجيه أقرب دورية",
                    SubCategoriesID = 19
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 65,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 19
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 66,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 19
                },
            #endregion

            #region Releated to Sub Category 20
                new ProcedureTypes
                {
                    ProcedureTypeID = 67,
                    ProcedureTypeName = "إبلاغ الدوريات الأمنية",
                    SubCategoriesID = 20
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 68,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 20
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 69,
                    ProcedureTypeName = "الإسعاف",
                    SubCategoriesID = 20
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 70,
                    ProcedureTypeName = "توجيه أقرب دورية",
                    SubCategoriesID = 20
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 71,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 20
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 72,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 20
                },
            #endregion

            #region Releated to Sub Category 21
                new ProcedureTypes
                {
                    ProcedureTypeID = 73,
                    ProcedureTypeName = "يتم إبلاغ المبلغ بإبلاغ الدوريات الأمنية أو التوجه للشرطة",
                    SubCategoriesID = 21
                },
            #endregion

            #region Releated to Sub Category 22
                //"لا يوجد إجراءات لبلاغات "أخرى" في دليل البلاغات - بلاغات متنوعة؟ "المفترض تكون في جنائية
            #endregion

            #region Releated to Sub Category 23
                new ProcedureTypes
                {
                    ProcedureTypeID = 74,
                    ProcedureTypeName = "إبلاغ الدوريات الأمنية",
                    SubCategoriesID = 23
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 75,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 23
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 76,
                    ProcedureTypeName = "توجيه أقرب دورية",
                    SubCategoriesID = 23
                },
            #endregion

            #region Releated to Sub Category 24
                new ProcedureTypes
                {
                    ProcedureTypeID = 77,
                    ProcedureTypeName = "يتم إبلاغ رئيس النوبة ودورية المنطقة وإبلاغ الدوريات الأمنية",
                    SubCategoriesID = 24
                },
            #endregion

            #region Releated to Sub Category 25
                  new ProcedureTypes
                  {
                      ProcedureTypeID = 78,
                      ProcedureTypeName = "إبلاغ الدفاع المدني",
                      SubCategoriesID = 25
                  },
                new ProcedureTypes
                {
                    ProcedureTypeID = 79,
                    ProcedureTypeName = "إبلاغ حماية البيئة",
                    SubCategoriesID = 25
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 80,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 25
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 81,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 25
                },
            #endregion

            #region Releated to Sub Category 26
                new ProcedureTypes
                {
                    ProcedureTypeID = 82,
                    ProcedureTypeName = "إبلاغ الشركة المختصة",
                    SubCategoriesID = 26
                },
            #endregion

            #region Releated to Sub Category 27
                new ProcedureTypes
                {
                    ProcedureTypeID = 83,
                    ProcedureTypeName = "إبلاغ حماية البيئة",
                    SubCategoriesID = 27
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 84,
                    ProcedureTypeName = "الدفاع المدني",
                    SubCategoriesID = 27
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 85,
                    ProcedureTypeName = "إطفاء الهيئة الملكية",
                    SubCategoriesID = 27
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 86,
                    ProcedureTypeName = "مناوب السلامة",
                    SubCategoriesID = 27
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 87,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 27
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 88,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 27
                },
            #endregion

            #region Releated to Sub Category 28
                 new ProcedureTypes
                 {
                     ProcedureTypeID = 89,
                     ProcedureTypeName = "إبلاغ حماية البيئة",
                     SubCategoriesID = 28
                 },
                new ProcedureTypes
                {
                    ProcedureTypeID = 90,
                    ProcedureTypeName = "الدفاع المدني",
                    SubCategoriesID = 28
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 91,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 28
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 92,
                    ProcedureTypeName = "مناوب السلامة",
                    SubCategoriesID = 28
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 93,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 28
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 94,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 28
                },
            #endregion

            #region Releated to Sub Category 29
                new ProcedureTypes
                {
                    ProcedureTypeID = 95,
                    ProcedureTypeName = "اتخاذ الإجراء حسب ما يتطلب الحدث",
                    SubCategoriesID = 29
                },
            #endregion

            #region Releated to Sub Category 30
                new ProcedureTypes
                {
                    ProcedureTypeID = 96,
                    ProcedureTypeName = "إبلاغ الشركة المختصة",
                    SubCategoriesID = 30
                },
            #endregion

            #region Releated to Sub Category 31
                new ProcedureTypes
                {
                    ProcedureTypeID = 97,
                    ProcedureTypeName = "إبلاغ الشركة المختصة",
                    SubCategoriesID = 31
                },
            #endregion

            #region Releated to Sub Category 32
                new ProcedureTypes
                {
                    ProcedureTypeID = 98,
                    ProcedureTypeName = "يتم إبلاغ رئيس النوبة توجيه التحقيق الإدارة المختصة إتباع الأولية حسب في الحدث حسب ما يتطلب",
                    SubCategoriesID = 32
                },
            #endregion

            #region Releated to Sub Category 33
                //لا يوجد إجراءات متنوعة في دليل البلاغات - بلاغات متنوعة
            #endregion

            #region Releated to Sub Category 34
                new ProcedureTypes
                {
                    ProcedureTypeID = 99,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 34
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 100,
                    ProcedureTypeName = "فني الأجراس",
                    SubCategoriesID = 34
                },
            #endregion

            #region Releated to Sub Category 35
                new ProcedureTypes
                {
                    ProcedureTypeID = 101,
                    ProcedureTypeName = "توجيه اقرب دورية للموقع",
                    SubCategoriesID = 35
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 102,
                    ProcedureTypeName = "إبلاغ الشركة المختصة",
                    SubCategoriesID = 35
                },
            #endregion

            #region Releated to Sub Category 36
                new ProcedureTypes
                {
                    ProcedureTypeID = 103,
                    ProcedureTypeName = "إبلاغ الشركة المختصة",
                    SubCategoriesID = 36
                },
            #endregion

            #region Releated to Sub Category 37
                new ProcedureTypes
                {
                    ProcedureTypeID = 104,
                    ProcedureTypeName = "توجيه أقرب دورية للموقع",
                    SubCategoriesID = 37
                },
            #endregion

            #region Releated to Sub Category 38
                new ProcedureTypes
                {
                    ProcedureTypeID = 105,
                    ProcedureTypeName = "إبلاغ الإسعاف",
                    SubCategoriesID = 38
                },
            #endregion

            #region Releated to Sub Category 39
                new ProcedureTypes
                {
                    ProcedureTypeID = 106,
                    ProcedureTypeName = "إبلاغ رئيس النوبة",
                    SubCategoriesID = 39
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 107,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 39
                },
            #endregion

            #region Releated to Sub Category 40
                new ProcedureTypes
                {
                    ProcedureTypeID = 108,
                    ProcedureTypeName = "إبلاغ الشركة المختصة في حال المنشأة خاصةالجامعة",
                    SubCategoriesID = 40
                },
            #endregion

            #region Releated to Sub Category 41
                new ProcedureTypes
                {
                    ProcedureTypeID = 109,
                    ProcedureTypeName = "إبلاغ إدارة النظافة",
                    SubCategoriesID = 41
                },
            #endregion

            #region Releated to Sub Category 42
                //لا يوجد إجراءات خاصة بجرس إنذار سرقة في دليل الإجراءات - بلاغات متنوعة
            #endregion

            #region Releated to Sub Category 43
                new ProcedureTypes
                {
                    ProcedureTypeID = 110,
                    ProcedureTypeName = "إبلاغ شركة مرافق",
                    SubCategoriesID = 43
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 111,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 43
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 112,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 43
                },
            #endregion

            #region Releated to Sub Category 44
                new ProcedureTypes
                {
                    ProcedureTypeID = 113,
                    ProcedureTypeName = "إبلاغ رئيس النوبة",
                    SubCategoriesID = 44
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 114,
                    ProcedureTypeName = "توجيه التحقيق",
                    SubCategoriesID = 44
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 115,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 44
                },
            #endregion

            #region Releated to Sub Category 45
                //لايوجد إجراءات بلاغ كاذب في دليل البلاغات - بلاغات متنوعة
            #endregion

            #region Releated to Sub Category 46
                new ProcedureTypes
                {
                    ProcedureTypeID = 116,
                    ProcedureTypeName = "إبلاغ العمليات المشتركة",
                    SubCategoriesID = 46
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 117,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 46
                },
            #endregion

            #region Releated to Sub Category 47
                new ProcedureTypes
                {
                    ProcedureTypeID = 118,
                    ProcedureTypeName = "إبلاغ حرس الحدود",
                    SubCategoriesID = 47
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 119,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 47
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 120,
                    ProcedureTypeName = "الإسعاف",
                    SubCategoriesID = 47
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 121,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 47
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 122,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 47
                },
            #endregion

            #region Releated to Sub Category 48
                //لايوجد إجراءات وفاة طبيعية في دليل البلاغات - إجراءات متنوعة
            #endregion

            #region Releated to Sub Category 49
                new ProcedureTypes
                {
                    ProcedureTypeID = 123,
                    ProcedureTypeName = "إبلاغ رئيس النوبة",
                    SubCategoriesID = 49
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 124,
                    ProcedureTypeName = "الدوريات الأمنية",
                    SubCategoriesID = 49
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 125,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 49
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 126,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 49
                },
            #endregion

            #region Releated to Sub Category 50
                new ProcedureTypes
                {
                    ProcedureTypeID = 127,
                    ProcedureTypeName = "إبلاغ رئيس النوبة",
                    SubCategoriesID = 50
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 128,
                    ProcedureTypeName = "الدوريات الأمنية",
                    SubCategoriesID = 50
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 129,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 50
                },
            #endregion

            #region Releated to Sub Category 51
                new ProcedureTypes
                {
                    ProcedureTypeID = 130,
                    ProcedureTypeName = "إبلاغ جهات الامنية",
                    SubCategoriesID = 51
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 131,
                    ProcedureTypeName = "الدفاع المدني",
                    SubCategoriesID = 51
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 132,
                    ProcedureTypeName = "القيادة والسيطرة ببالجهات الامنية",
                    SubCategoriesID = 51
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 133,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 51
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 134,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 51
                },
            #endregion

            #region Releated to Sub Category 52
                new ProcedureTypes
                {
                    ProcedureTypeID = 135,
                    ProcedureTypeName = "الدوريات الأمنية",
                    SubCategoriesID = 52
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 136,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 52
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 137,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 52
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 138,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 52
                },
            #endregion

            #region Releated to Sub Category 53
                new ProcedureTypes
                {
                    ProcedureTypeID = 139,
                    ProcedureTypeName = "الدوريات الأمنية",
                    SubCategoriesID = 53
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 140,
                    ProcedureTypeName = "الدفاع المدني",
                    SubCategoriesID = 53
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 141,
                    ProcedureTypeName = "القيادة والسيطرة بالجهاز الامني",
                    SubCategoriesID = 53
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 142,
                    ProcedureTypeName = "الإسعاف",
                    SubCategoriesID = 53
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 143,
                    ProcedureTypeName = "إبلاغ الدفاع المدني",
                    SubCategoriesID = 53
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 144,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 53
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 145,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 53
                },
            #endregion

            #region Releated to Sub Category 54
                new ProcedureTypes
                {
                    ProcedureTypeID = 146,
                    ProcedureTypeName = "إبلاغ الدوريات الأمنية",
                    SubCategoriesID = 54
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 147,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 54
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 148,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 54
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 149,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 54
                },
            #endregion

            #region Releated to Sub Category 55
                new ProcedureTypes
                {
                    ProcedureTypeID = 150,
                    ProcedureTypeName = "إبلاغ الدوريات الأمنية",
                    SubCategoriesID = 55
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 151,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 55
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 152,
                    ProcedureTypeName = "الإسعاف",
                    SubCategoriesID = 55
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 153,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 55
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 154,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 55
                },
            #endregion

            #region Releated to Sub Category 56
                new ProcedureTypes
                {
                    ProcedureTypeID = 155,
                    ProcedureTypeName = "إبلاغ الدوريات الأمنية",
                    SubCategoriesID = 56
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 156,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 56
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 157,
                    ProcedureTypeName = "العميات المشتركة",
                    SubCategoriesID = 56
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 158,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 56
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 159,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية",
                    SubCategoriesID = 56
                },
            #endregion

            #region Releated to Sub Category 57
                new ProcedureTypes
                {
                    ProcedureTypeID = 160,
                    ProcedureTypeName = "إبلاغ القيادة والسيطرة بوزارة الداخلية",
                    SubCategoriesID = 57
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 161,
                    ProcedureTypeName = "العميات المشتركة",
                    SubCategoriesID = 57
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 162,
                    ProcedureTypeName = "الدوريات الأمنية",
                    SubCategoriesID = 57
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 163,
                    ProcedureTypeName = "رئيس النوبة",
                    SubCategoriesID = 57
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 164,
                    ProcedureTypeName = "اتباع الأولوية في الحدث حسب ما يتطلب",
                    SubCategoriesID = 57
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 165,
                    ProcedureTypeName = "إحاطة الاجهزة الامنية ",
                    SubCategoriesID = 57
                },
            #endregion

            #region Releated to Sub Category 58
                new ProcedureTypes
                {
                    ProcedureTypeID = 166,
                    ProcedureTypeName = "(إبلاغ المناوب (لرفع تقرير عن الحالة",
                    SubCategoriesID = 58
                },
            #endregion

            #region Releated to Sub Category 59
                new ProcedureTypes
                {
                    ProcedureTypeID = 167,
                    ProcedureTypeName = "(إبلاغ المناوب (لرفع تقرير عن الحالة",
                    SubCategoriesID = 59
                },
            #endregion

            #region Releated to Sub Category 60
                new ProcedureTypes
                {
                    ProcedureTypeID = 168,
                    ProcedureTypeName = "(إبلاغ المناوب (لرفع تقرير عن الحالة",
                    SubCategoriesID = 60
                },
            #endregion

            #region Releated to Sub Category 61
                new ProcedureTypes
                {
                    ProcedureTypeID = 169,
                    ProcedureTypeName = "(إبلاغ المناوب (لرفع تقرير عن الحالة",
                    SubCategoriesID = 61
                },
            #endregion

            #region Releated to Sub Category 62
                new ProcedureTypes
                {
                    ProcedureTypeID = 170,
                    ProcedureTypeName = "(إبلاغ المناوب (لرفع تقرير عن الحالة",
                    SubCategoriesID = 62
                },
            #endregion

            #region Releated to Sub Category 63
                new ProcedureTypes
                {
                    ProcedureTypeID = 171,
                    ProcedureTypeName = "يتم توجيه التحقيق",
                    SubCategoriesID = 63
                },
                new ProcedureTypes
                {
                    ProcedureTypeID = 172,
                    ProcedureTypeName = "إبلاغ الشرطة في حال وجود إدعاء من قبل المصاب على المنشأة أو في حاله مدة الشفاء 15 يوم فأكثر أو في حال إدعاء المصاب",
                    SubCategoriesID = 63
                },
            #endregion

            #region Releated to Sub Category 64
                new ProcedureTypes
                {
                    ProcedureTypeID = 173,
                    ProcedureTypeName = "توجيه مناوب السلامة",
                    SubCategoriesID = 64
                },
            #endregion

            #region Releated to Sub Category 65
                new ProcedureTypes
                {
                    ProcedureTypeID = 174,
                    ProcedureTypeName = "توجيه مناوب السلامة",
                    SubCategoriesID = 65
                },
            #endregion

            #region Releated to Sub Category 66
            //لايوجد اجراءات مخالفة سلامة في دليل البلاغات - بلاغات متنوعة
            #endregion

            #region Releated to Sub Category 67
            //لا يوجد إجراءات
            #endregion

            #region Releated to Sub Category 68
            new ProcedureTypes
            {
                ProcedureTypeID = 175,
                ProcedureTypeName = "إبلاغ إدارة المباني",
                SubCategoriesID = 68
            },
            #endregion

            #region Releated to Sub Category 69
            //لا يوجد إجراءات
            #endregion

            #region Releated to Sub Category 70
            //لا يوجد إجراءات
            #endregion

            #region Releated to Sub Category 71
            //لا يوجد إجراءات
            #endregion

            #region Releated to Sub Category 72
            new ProcedureTypes
            {
                ProcedureTypeID = 176,
                ProcedureTypeName = "إبلاغ إدراة النظافة",
                SubCategoriesID = 72
            }
            #endregion

                );

            builder.Entity<Districts>().HasData(
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

                );






           




        }


        public DbSet<Districts> Districts { get; set; }     
        public DbSet<Logs> Logs { get; set; }
        public DbSet<MainCategories> MainCategories { get; set; }
        public DbSet<Nationalities> Nationalities { get; set; }
        public DbSet<ProcedureReferences> ProcedureReferences { get; set; }
        public DbSet<ProcedureTypes> ProcedureTypes { get; set; }
        public DbSet<ProcedureRelations> ProceduerRelations { get; set; }
        
        public DbSet<Report> Report { get; set; }
        public DbSet<SubCategories> SubCategories { get; set; }
        
        public DbSet<Vehicles> Vehicles { get; set; }


        public DbSet<LostCardEmployee> LostCardEmployees { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Lost> Losts { get; set; }
        public DbSet<Informer> Informers { get; set; }

        
    }
}
