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
    internal class BLExpense
    {
        public int ExpenseId { get; set; }
        public string Expense { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public int ExpenseHeadid { get; set; }

        public static int Save(BLExpense obj)
        {
            SqlParameter[] prm = new SqlParameter[6];
            prm[0] = new SqlParameter("@Execute", "insert");
            prm[1] = new SqlParameter("@Expense", obj.Expense);
            prm[2] = new SqlParameter("@Amount", obj.Amount);
            prm[3] = new SqlParameter("@Status", obj.Status);
            prm[4] = new SqlParameter("@Date", obj.Date);
            prm[5] = new SqlParameter("@ExpenseHeadID", obj.ExpenseHeadid);
            return DataAccess.SpExecuteQuery("SpExpense", prm);
        }
        public static int Update(BLExpense obj)
        {
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter("@Execute", "update");
            prm[1] = new SqlParameter("@Expense", obj.Expense);
            prm[2] = new SqlParameter("@Amount", obj.Amount);
            prm[3] = new SqlParameter("@Status", obj.Status);
            prm[4] = new SqlParameter("@Date", obj.Date);
            prm[5] = new SqlParameter("@ExpenseHeadID", obj.ExpenseHeadid);
            prm[6] = new SqlParameter("@ExpenseId", obj.ExpenseId);
            return DataAccess.SpExecuteQuery("SpExpense", prm);
        }
        public static int Delete(int ID)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "delete");
            prm[1] = new SqlParameter("@Expense", ID);
            return DataAccess.SpExecuteQuery("SpExpense", prm);
        }
        public static DataTable GetData()
        {
            SqlParameter prm = new SqlParameter("@Execute", "select");
            return DataAccess.SpGetData("SpExpense", prm);
        } 
      
    }
}
