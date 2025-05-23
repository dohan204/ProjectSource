using DataAccessLayer;
using Entityes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer
{
    public class BUserRole
    {
        //private static DataTable GetAll()
        //{
        //   return DUserRole.GetAll();
        //}
        public static void NewUserAccount(UserAccount userAccount)
        {
            DUserAccount.NewUser(userAccount);
        }
        public static DataTable GetAll()
        {
            return DUserRole.GetAll();
        }
        public static void UpdateUser(UserAccount userAccount)
        {
            DUserAccount.UpdateUser(userAccount);
        }
        public static void DeleteUser(int UserID)
        {
            DUserAccount.DeleteUser(UserID);
        }

    }
}
