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
    public class BUserAccount
    {
        public static bool IsExitesAccount(UserAccount userAccount)
        {
            return DUserAccount.IsExitesAccount(userAccount);
        }
        public static void UpdatePassword(UserAccount userAccount)
        {
            DUserAccount.UpdatePassword(userAccount);
        }
        public static void NewUserAccount(UserAccount userAccount)
        {
            DUserAccount.NewUser(userAccount);
        }
        public static DataTable GetAll()
        {
            return DUserAccount.GetAll();
        }
        public static void UpdateUser(UserAccount userAccount)
        {
            DUserAccount.UpdateUser(userAccount);
        }
        public static void DeleteUser(int UserID)
        {
            DUserAccount.DeleteUser(UserID);
        }
        public static DataTable Search(string keyword)
        {
            return DUserAccount.Search(keyword);
        }
    }
}
