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
    public class DUserAccount
    {
        private static string conStr = "server=FC-HAN\\SQLEXPRESS;database=TestProjectDB;integrated security=true;";
        public static bool IsExitesAccount(UserAccount userAccount)
        {
            bool isExist = false;
            // thuc hien ket noi toi co so du lieu de kiem tra
            //string conStr = "server=FC-HAN\\SQLEXPRESS;database=TestProjectDB;integrated security=true;";
            SqlConnection sqlConnection = new SqlConnection(conStr);

            // mo ket noi, kiem tra thu tuc
            try
            {
                //mo ket noi
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UserAccount_CheckExist", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserName", userAccount.UserName);
                sqlCommand.Parameters.AddWithValue("@Password", userAccount.Password);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    isExist = true;
                }
                dataReader.Close();
                dataReader.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
        }
        public static void UpdatePassword(UserAccount userAccount)
        {
            // thuc hien ket noi toi co so du lieu de kiem tra
            
            SqlConnection sqlConnection = new SqlConnection(conStr);

            // mo ket noi, kiem tra thu tuc
            try
            {
                //mở kết nối tới cơ sở dữ liệu
                sqlConnection.Open();
                // tạo lệnh SQL để thực thi thủ tục stored procedure
                SqlCommand sqlCommand = new SqlCommand("UserAccount_ChangePassword", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                // truyền tham số cho thủ tục
                sqlCommand.Parameters.AddWithValue("@UserName", userAccount.UserName);
                sqlCommand.Parameters.AddWithValue("@NewPassword", userAccount.NewPassword);
                // sử dụng ExecuteNonQuery() để thực thi Update, Insert, Delete
                sqlCommand.ExecuteNonQuery();
                // giải phóng tài nguyên 
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
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
                DataTable dtTable = SqlHelper.ExecuteDataset(conStr, CommandType.StoredProcedure, "UserAccount_Select").Tables[0];
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
        public static DataTable Search(string keyword, string roleFilter)
        {
            try
            {
                DataTable dtTable = SqlHelper.ExecuteDataset(conStr,CommandType.StoredProcedure
                                                            ,"UserAccount_Search", new SqlParameter("@keyword", keyword),
                                                                                    new SqlParameter("@roleId", roleFilter)).Tables[0];
                return dtTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
