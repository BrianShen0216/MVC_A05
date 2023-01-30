using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class DALClass
    {
        public int AddUser_DAL(Users u)
        {
            using (var dbCtx = new UserDBEntities())
            {
                try
                {
                    dbCtx.Users.Add(u);
                    dbCtx.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    throw new Exception("Error occured when adding users " + e.Message);
                }
            }
        }

        public List<Users> GetAllUser_DAL()
        {
            using (var db = new UserDBEntities())
            {
                try
                {
                    var user_list = db.Users.ToList();
                    return user_list;
                }
                catch (Exception e)
                {
                    throw new Exception("Error occured when retreving user data " + e.Message);
                }
            }
        }
    }
}
