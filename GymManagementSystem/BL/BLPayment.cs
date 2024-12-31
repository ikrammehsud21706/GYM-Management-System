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
    internal class BLPayment
    {
        public int PaymentId { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public int CustomerId { get; set; }

        public static int Save(BLPayment obj)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Execute", "insert");
            prm[1] = new SqlParameter("@Amount", obj.Amount);
            prm[2] = new SqlParameter("@Date", obj.Date);
            prm[3] = new SqlParameter("@CustomerId", obj.CustomerId);
            return DataAccess.SpExecuteQuery("SpPayment", prm);
        }
        public static int Update(BLPayment obj)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Execute", "update");
            prm[1] = new SqlParameter("@Amount", obj.Amount);
            prm[2] = new SqlParameter("@Date", obj.Date);
            prm[3] = new SqlParameter("@CustomerId", obj.CustomerId);
            prm[4] = new SqlParameter("@PaymentId", obj.PaymentId);
            return DataAccess.SpExecuteQuery("SpPayment", prm);
        } 
        public static int Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "delete");
            prm[1] = new SqlParameter("@PaymentId",id);
            return DataAccess.SpExecuteQuery("SpPayment", prm);
        } 
        public static DataTable GetData(string Date=null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "select");
            prm[1] = new SqlParameter("@Date", Date);
            return DataAccess.SpGetData("SpPayment", prm);
        }
        public static DataTable Searching(string ColumnName,string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "search");
            prm[1] = new SqlParameter("@"+ColumnName, value);
            return DataAccess.SpGetData("SpPayment", prm);
        } 
        public static DataTable CheckPayment(int CustomerId , string Date)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", "checkpayment");
            prm[1] = new SqlParameter("@CustomerId", CustomerId);
            prm[2] = new SqlParameter("@Date", Date);
            return DataAccess.SpGetData("SpPayment", prm);
        }
        public static DataTable SelectDefaulterCustomer(int CustomerId )
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "SelectDefaulterCustomer");
           // prm[1] = new SqlParameter("@Date", Date);
            prm[1] = new SqlParameter("@CustomerId", CustomerId);
            return DataAccess.SpGetData("SpPayment", prm);
        }
    }
}
