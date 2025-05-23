using Entityes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;

namespace DataAccessLayer
{
    public class DUserRole
    {
        private static string conStr = "server=FC-HAN\\SQLEXPRESS;database=TestProjectDB;integrated security=true;";

        public static void NewUser(UserAccount user)
        {
            // sử dụng nonQuery để thực hiện thao tác : Insert, Update, Delete
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "UserAccount_Insert", user.RoleId,
                                                                        user.UserName,
                                                                        user.Password,
                                                                        user.FullName,
                                                                        user.PhoneNumber,
                                                                        user.Email,
                                                                        user.Address,
                                                                        user.Birthday,
                                                                        user.CreatedBy,
                                                                        user.ModifiedBy, user.Note);                          
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetAll()
        {
            try
            {
                // dataset có thể chứa nhiều bảng, ở đây đểlấy một bảng dùng 
                DataTable dtTable = SqlHelper.ExecuteDataset(conStr, CommandType.StoredProcedure, "UserRole_SelectAll").Tables[0];
                return dtTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateUser(UserAccount user)
        {
           
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "UserAccount_Updates", // đúng tên SP
                                            user.UserId,
                                            user.RoleId,
                                            user.UserName,
                                            user.Password,
                                            user.FullName,
                                            user.PhoneNumber,
                                            user.Email,
                                            user.Address,
                                            user.Birthday,
                                            user.Note,
                                            user.ModifiedBy
                );

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void DeleteUser(int UserID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "UserAccount_Delete", UserID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable Search(string keyword)
        {
            try
            {
                DataTable dtTable = SqlHelper.ExecuteDataset(conStr,CommandType.StoredProcedure
                                                            ,"UserAccount_Search", new SqlParameter("@keyword", keyword)).Tables[0];
                return dtTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
