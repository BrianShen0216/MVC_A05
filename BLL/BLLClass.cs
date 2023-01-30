using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class BLLClass
    {
        public List<Users> GetAllUsers_BLL()
        {
            return new DALClass().GetAllUser_DAL();
        }

        public int AddUser_BLL(Users u)
        {
            return new DALClass().AddUser_DAL(u);
        }
    }
}
