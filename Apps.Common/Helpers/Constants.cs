using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Common.Helpers
{
    public class Constants
    {
        public const string Success = "Success";
        public const string Error = "Error";
        public const string Unauthorized = "Unauthorized";
        public const string Excep = "Excep";
        public const string USER_SESSION = "USER_SESSION";
        public const string USER_ID = "USER_ID";
        public const string COMPANY = "COMPANY";
        public const string USER_MENU = "USER_MENU";
        public const string COMPANY_ID = "COMPANY_ID";

        public enum UserTypeEnum { POApprovalLavel = 1, AdminLevel = 2, POLevel = 3, SupervisorLevel = 4, EntryLevel = 5, POAdminLevel = 6 }

        public enum StockTypeEnum { StockIssue = 1, StockReceive = 2, StockTrasferIssue = 3, StockTransferReceive = 4 }

        public enum StatusEnum { New = 1, Pending = 2, SemiApprove = 3, Approve = 4, Reject = 5, Cancel = 6 }

    }
}
