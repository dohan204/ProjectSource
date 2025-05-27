using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entityes;
namespace BussinessAccessLayer
{
    public class BTestHistory
    {
        public static void SaveResult(TestHistory history)
        {
            DTestHistory.SaveResult(history);
        }
        public static DataTable LoaderBoard(TestHistory testHistory)
        {
            return DTestHistory.LoaderBoard(testHistory);
        }
    }
}
