using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Common.DBEntities
{
    public partial class UserMaster
    {
        [Key]
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Pwd { get; set; }

        public string UserFullName { get; set; }

        public string EmailId { get; set; }

        public int UserTypeID { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int CompanyID { get; set; }

        public int IsEmailVerified { get; set; }

        public int IsApproved { get; set; }
    }
}