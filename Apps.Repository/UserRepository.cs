using Apps.Common.DBContext;
using Apps.Common.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Repository
{
    public class UserRepository
    {
        private AppDataContext DB;

        public UserRepository(AppDataContext dbContext)
        {
            this.DB = dbContext;
        }

        public UserMaster Authentication(UserMaster usr)
        {
            return DB.UserMasters.FirstOrDefault(e => (e.UserName == usr.UserName || e.EmailId == usr.EmailId) && e.Pwd == usr.Pwd);
        }

        public bool IsEmailAlreadyExist(string emailID)
        {
            var v = DB.UserMasters.Where(a => a.EmailId == emailID).FirstOrDefault();
            return v != null;
        }

        public int Create(UserMaster model)
        {
            DB.UserMasters.Add(model);
            int result = DB.SaveChanges();
            return result;
        }

        public IQueryable<UserMaster> GetAll()
        {
            return DB.UserMasters;
        }

    }
}
