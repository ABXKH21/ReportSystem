using System.Collections.Generic;

namespace ReportSystem.Constants
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
        }

      

        public static class Report
        {
            public const string View = "Permissions.Report.View";
            public const string Create = "Permissions.Report.Create";
            public const string Edit = "Permissions.Report.Edit";
            public const string Delete = "Permissions.Report.Delete";
        }

        public static class Losts
        {
            public const string View = "Permissions.Losts.View";
            public const string Create = "Permissions.Losts.Create";
            public const string Edit = "Permissions.Losts.Edit";
            public const string Delete = "Permissions.Losts.Delete";
        }

        public static class LostCards
        {
            public const string View = "Permissions.LostCards.View";
            public const string Create = "Permissions.LostCards.Create";
            public const string Edit = "Permissions.LostCards.Edit";
            public const string Delete = "Permissions.LostCards.Delete";
        }

        public static class Delivery
        {
            public const string View = "Permissions.Delivery.View";
            public const string Create = "Permissions.Delivery.Create";
            public const string Edit = "Permissions.Delivery.Edit";
            public const string Delete = "Permissions.Delivery.Delete";
        }

    }
}
