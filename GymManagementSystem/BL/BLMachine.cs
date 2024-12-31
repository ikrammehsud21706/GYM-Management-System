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
    internal class BLMachine
    {
        public int machineid { get; set; }
        public string machinename { get; set; }
        public string status { get; set; }

        public static int Save(BLMachine obj)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", "insert");
            prm[1] = new SqlParameter("@MachineName", obj.machinename);
            prm[2] = new SqlParameter("@Status", obj.status);
            return DataAccess.SpExecuteQuery("SpMachine", prm);
        } 
        public static int Update(BLMachine obj)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Execute", "update");
            prm[1] = new SqlParameter("@MachineName", obj.machinename);
            prm[2] = new SqlParameter("@Status", obj.status);
            prm[3] = new SqlParameter("@MachineId", obj.machineid);
            int check=DataAccess.SpExecuteQuery("SpMachine", prm);
            return check;
        }
        public static int Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "delete");
            prm[1] = new SqlParameter("@MachineId",id) ;
            int check=DataAccess.SpExecuteQuery("SpMachine", prm);
            return check;
        }
        public static DataTable GetData()
        {
            SqlParameter prm = new SqlParameter("@Execute", "select");
            return DataAccess.SpGetData("SpMachine", prm);
        }
        public static DataTable Searching(string ColumnName,string value) 
        {
            SqlParameter[] prm=new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "search");
            prm[1] = new SqlParameter("@"+ColumnName,value);
            return DataAccess.SpGetData("SpMachine", prm);
        }
    }
}
