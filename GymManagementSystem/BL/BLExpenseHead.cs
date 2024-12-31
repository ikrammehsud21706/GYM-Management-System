using GymManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.BL
{
    internal class BLExpenseHead
    {
        public int ExpenseHeadId { get; set; }
        public string ExpenseHead { get; set; }
        public string Status { get; set; }

        public static int Save(BLExpenseHead obj)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", "insert");
            prm[1] = new SqlParameter("@ExpenseHead", obj.ExpenseHead);
            prm[2] = new SqlParameter("@Status", obj.Status);
          return  DataAccess.SpExecuteQuery("SpExpenseHead", prm);
        } 
        public static int Update(BLExpenseHead obj)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Execute", "update");
            prm[1] = new SqlParameter("@ExpenseHead", obj.ExpenseHead);
            prm[2] = new SqlParameter("@Status", obj.Status);
            prm[3] = new SqlParameter("@ExpenseHeadId", obj.ExpenseHeadId);
            int check= DataAccess.SpExecuteQuery("SpExpenseHead", prm);
            return check;
        }
        public static int Delete(int Id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "delete");
            prm[1] = new SqlParameter("@ExpenseHeadId", Id);
            int check=DataAccess.SpExecuteQuery("SpExpenseHead", prm);
            return check;
        } 
        public static DataTable GetData()
        {
            SqlParameter prm = new SqlParameter("@Execute", "select");
            return DataAccess.SpGetData("SpExpenseHead", prm);
        }
        public static DataTable GetLatestExpenseHead()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Execute", "GetLatestExpenseHead");
            return DataAccess.SpGetData("SpExpenseHead", prm);
        }
        public static DataTable Searching(string ColumnName,string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "Search");
            prm[1] = new SqlParameter("@"+ColumnName, value);
            return DataAccess.SpGetData("SpExpenseHead", prm);
        }

    }
}
