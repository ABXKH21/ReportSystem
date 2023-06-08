using ReportSystem.Context;
using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.Repo
{
    public class NationalitiesRepository : INationalitiesRepository
    {
        private readonly ReportSysContext reportSysContext;

        public NationalitiesRepository(ReportSysContext reportSysContext)
        {
            this.reportSysContext = reportSysContext;
        }
        public List<Nationalities> GetAllNationalities()
        {
            var Nationalities = new List<Nationalities>
            {
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
            };
            return Nationalities;
        }

        public IEnumerable<Nationalities> GetGetAllNationalitiesIEnum()
        {
            return  reportSysContext.Nationalities;            
        }
    }
}
