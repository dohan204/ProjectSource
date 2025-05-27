using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Entityes;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DTestHistory
    {
        private static string conStr = "server=FC-HAN\\SQLEXPRESS;database=TestProjectDB;integrated security=true;";

        public static void SaveResult(TestHistory history)
        {
           
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "TestHistory_Insert", history.UserId,
                                                                        history.SubjectId,
                                                                        history.TestDate,
                                                                        history.CorrectAnswer,
                                                                        history.TotalQuestion,
                                                                        history.Mark,
                                                                        history.CreatedBy);
			}
			catch (Exception ex)
			{
                throw ex;
            }
        } 
        public static DataTable LoaderBoard(TestHistory testHistory)
        {
            try
            {
               DataTable dtData =  SqlHelper.ExecuteDataset(conStr, CommandType.StoredProcedure, "TestHistory_Select", new SqlParameter("@SubjectId", testHistory.SubjectId)).Tables[0];
                return dtData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
