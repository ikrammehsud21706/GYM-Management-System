using GymManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.BL
{
    internal class BLSalary
    {
        public int SalaryId { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public int TrainerId { get; set; }

        public static int Save(BLSalary obj)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Execute", "insert");
            prm[1] = new SqlParameter("@Amount", obj.Amount);
            prm[2] = new SqlParameter("@Date", obj.Date);
            prm[3] = new SqlParameter("@TrainerId", obj.TrainerId);
            return DataAccess.SpExecuteQuery("SpSalary", prm);
        }
        public static int Update(BLSalary obj)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Execute", "update");
            prm[1] = new SqlParameter("@Amount", obj.Amount);
            prm[2] = new SqlParameter("@Date", obj.Date);
            prm[3] = new SqlParameter("@TrainerId", obj.TrainerId);
            prm[4] = new SqlParameter("@SalaryId", obj.SalaryId);
            return DataAccess.SpExecuteQuery("SpSalary", prm);
        }
        public static int Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "delete");
            prm[1] = new SqlParameter("@SalaryId", id);
            return DataAccess.SpExecuteQuery("SpSalary", prm);
        }
        public static DataTable GetData(string Date = null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "select");
            prm[1] = new SqlParameter("@Date", Date);
            return DataAccess.SpGetData("SpSalary", prm);
        }
        public static DataTable Searching(string ColumnName, string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "search");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpSalary", prm);
        }
    }
}
