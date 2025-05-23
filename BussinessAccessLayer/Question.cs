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
    public class BQuestion
    {
        public static void NewQuestion(Question question)
        {
            DQuestion.AddQuestion(question);
        }
        public static DataTable GetAll()
        {
            return DQuestion.GetAll();
        }
        public static void UpdateUser(Question question)
        {
            DQuestion.UpdateQuestion(question);
        }
        public static void DeleteSubject(int questionId)
        {
            DQuestion.DeleteQuestion(questionId);
        }
        public static DataTable Search(string keyword)
        {
            return DQuestion.Search(keyword);
        }
    }
}
