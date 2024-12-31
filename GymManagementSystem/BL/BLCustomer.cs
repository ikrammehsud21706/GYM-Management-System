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
    internal class BLCustomer
    {
        public int customerid { get; set; }
        public string customername { get; set; }
        public string contact { get; set; }
        public string cnic { get; set; }
        public string address { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string gender { get; set; }
        public int trainerid { get; set; }

        public static int Save(BLCustomer obj)
        {
            SqlParameter[] prm = new SqlParameter[11];
            prm[0] = new SqlParameter("@Execute", "insert");
            prm[1] = new SqlParameter("@CustomerName", obj.customername);
            prm[2] = new SqlParameter("@Contact", obj.contact);
            prm[3] = new SqlParameter("@CNIC", obj.cnic);
            prm[4] = new SqlParameter("@Address", obj.address);
            prm[5] = new SqlParameter("@Status", obj.status);
            prm[6] = new SqlParameter("@Type", obj.type);
            prm[7] = new SqlParameter("@Age", obj.age);
            prm[8] = new SqlParameter("@Weight", obj.weight);
            prm[9] = new SqlParameter("@Gender", obj.gender);
            prm[10] = new SqlParameter("@TrainerId", obj.trainerid);
            return DataAccess.SpExecuteQuery("SpCustomer", prm);
        }
        public static int Update(BLCustomer obj)
        {
            SqlParameter[] prm = new SqlParameter[12];
            prm[0] = new SqlParameter("@Execute", "update");
            prm[1] = new SqlParameter("@CustomerName", obj.customername);
            prm[2] = new SqlParameter("@Contact", obj.contact);
            prm[3] = new SqlParameter("@CNIC", obj.cnic);
            prm[4] = new SqlParameter("@Address", obj.address);
            prm[5] = new SqlParameter("@Status", obj.status);
            prm[6] = new SqlParameter("@Type", obj.type);
            prm[7] = new SqlParameter("@Age", obj.age);
            prm[8] = new SqlParameter("@Weight", obj.weight);
            prm[9] = new SqlParameter("@Gender", obj.gender);
            prm[10] = new SqlParameter("@TrainerID", obj.trainerid);
            prm[11] = new SqlParameter("@CustomerID", obj.customerid);
            return DataAccess.SpExecuteQuery("SpCustomer", prm);
        }
        public static int Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "delete");
            prm[1] = new SqlParameter("@CustomerID", id);
            int check = DataAccess.SpExecuteQuery("SpCustomer", prm);
            return check;
        }
        public static DataTable GetData(int? CustomerId = null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "select");
            prm[1] = new SqlParameter("@CustomerId", CustomerId);
            return DataAccess.SpGetData("SpCustomer", prm);
        }
        public static DataTable CheckCustomer(string ColumnName, string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "select");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpCustomer", prm);
        }
        public static DataTable CheckCustomerInUpdate(string ColumnName, string value, int id)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", "selectInUpdate");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            prm[2] = new SqlParameter("@CustomerID", id);
            return DataAccess.SpGetData("SpCustomer", prm);
        }
        public static DataTable Searching(string ColumnName, string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "search");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpCustomer", prm);
        }
        public static DataTable GetSpecificCustomerRecord(int? CustomerId=null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "select");
            prm[1] = new SqlParameter("@CustomerId", CustomerId);
            return DataAccess.SpGetData("SpCustomer", prm);
        }
        public static DataTable GetCustomerMaxId()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Execute", "MaxCustomerId");
            return DataAccess.SpGetData("SpCustomer", parameters);
        }
        public static DataTable GetCustomersForTrainerId(int? TrainerId = null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "SelectCustomerForTrainerId");
            prm[1] = new SqlParameter("@TrainerId", TrainerId);
            return DataAccess.SpGetData("SpCustomer", prm);
        }

    }
}
