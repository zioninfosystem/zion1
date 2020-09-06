using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Apps.Common.DBContext;
using Apps.Repository;

namespace LogisticProjects.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDataContext _db;
        private readonly UserRepository userRepo;

        public UserController()
        {
            _db = new AppDataContext();
            userRepo = new UserRepository(_db);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_db != null)
                {
                    _db.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}