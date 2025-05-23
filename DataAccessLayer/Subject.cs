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
    public class DSubject
    {
        private static string conStr = "server=FC-HAN\\SQLEXPRESS;database=TestProjectDB;integrated security=true;";

        public static void NewUser(Subject01 subject)
        {
            // sử dụng nonQuery để thực hiện thao tác : Insert, Update, Delete
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "Subject_Insert", subject.SubjectID,
                                            subject.SubjectName,
                                            subject.Description,
                                            subject.CreatedBy,
                                            subject.ModifiedBy);                          
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
                DataTable dtTable = SqlHelper.ExecuteDataset(conStr, CommandType.StoredProcedure, "Subject_SelectAll").Tables[0];
               
                return dtTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateSubject(Subject01 subject)
        {
           
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "Subject_Update", // đúng tên SP
                                            subject.SubjectID,
                                            subject.SubjectName,
                                            subject.Description,
                                            subject.ModifiedBy
                );

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void DeleteUser(string SubjectID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "Subject_Delete", SubjectID);
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
                                                            ,"Subject_Search", new SqlParameter("@keyword", keyword)).Tables[0];
                return dtTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
