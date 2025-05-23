using DataAccessLayer;
using Entityes;
using System.Data;

namespace BussinessAccessLayer
{
    public class BSubject01

    {
        public static void NewSubject(Subject01 subject)
        {
            DSubject.NewUser(subject);
        }
        public static DataTable GetAll()
        {
            return DSubject.GetAll();
        }
        public static void UpdateSubject(Subject01 subject)
        {
            DSubject.UpdateSubject(subject);
        }
        public static void DeleteSubject(string subjectId)
        {
            DSubject.DeleteUser(subjectId);
        }
        public static DataTable Search(string keyword)
        {
            return DSubject.Search(keyword);
        }
    }
}
