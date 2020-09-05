using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Common.Entities
{
    public class UserMaster
    {
        [Key]
        public int UserId { get; set; }

        public int UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PwdSalt { get; set; }

    }
}