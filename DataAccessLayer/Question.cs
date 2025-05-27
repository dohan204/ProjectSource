using Entityes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace DataAccessLayer
{
    public class DQuestion
    {
        private static string conStr = "server=FC-HAN\\SQLEXPRESS;database=TestProjectDB;integrated security=true;";

        public static void AddQuestion(Question question)
        {
            // sử dụng nonQuery để thực hiện thao tác : Insert, Update, Delete
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "Question_Insert",
                                            question.SubjectId,
                                            question.QContent,
                                            question.OptionA,
                                            question.OptionB,
                                            question.OptionC,
                                            question.OptionD,
                                            question.Answer,
                                            question.CreatedBy);                          
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
                DataTable dtTable = SqlHelper.ExecuteDataset(conStr, CommandType.StoredProcedure, "Question_SelectAll").Tables[0];
                return dtTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateQuestion(Question question)
        {
            /*
             * @QuestionId 
            ,@SubjectId   
            ,@QContent   
            ,@OptionA   
            ,@OptionB   
            ,@OptionC   
            ,@OptionD   
            ,@Answer   
            ,@CreatedBy   
            ,GETDATE()   
            ,@ModifiedBy   
            ,GETDATE(
             */
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "Question_Updates", // đúng tên SP
                                            question.QuestionId,
                                            question.SubjectId,
                                            question.QContent,
                                            question.OptionA,
                                            question.OptionB,
                                            question.OptionC,
                                            question.OptionD,
                                            question.Answer,
                                            question.ModifiedBy
                );

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void DeleteQuestion(int QuestionID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(conStr, "Question_Delete", QuestionID);
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
                                                            ,"Question_Search", new SqlParameter("@keyword", keyword)).Tables[0];
                return dtTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetQuestionForTest(string subjectId, int numberOfQuestion)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(conStr, CommandType.StoredProcedure,
                                                        "GetQuestionForTest", new SqlParameter("@SubjectId", subjectId),
                                                        new SqlParameter("@NumberOfQuestion", numberOfQuestion)).Tables[0];
                return dtData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static Question getOneQuestion(int questionId)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(conStr,CommandType.StoredProcedure,
                                                        "GetOneQuestion", new SqlParameter("@QuestionId", questionId));
                Question question = new Question();
                if (reader.Read())
                {
                    question.QuestionId = questionId;
                    question.QContent = reader["QContent"].ToString();
                    question.OptionA = reader["OptionA"].ToString();
                    question.OptionB = reader["OptionB"].ToString();
                    question.OptionC = reader["OptionC"].ToString();
                    question.OptionD = reader["OptionD"].ToString();
                    question.Answer = reader["Answer"].ToString();
                }
                reader.Close();
                return question;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
