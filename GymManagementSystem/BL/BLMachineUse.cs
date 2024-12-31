using GymManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymManagementSystem.BL
{
    internal class BLMachineUse
    {
        public int CustomerId { get; set; }
        public int MachineId { get; set; }
        public int MachineUseId { get; set; }
        public string Status { get; set; }
        public string time { get; set; }
        public static int Save(BLMachineUse obj)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@Execute", "insert");
            parameters[1] = new SqlParameter("@CustomerId", obj.CustomerId);
            parameters[2] = new SqlParameter("@MachineId", obj.MachineId);
            parameters[3] = new SqlParameter("@Status", obj.Status);
            parameters[4] = new SqlParameter("@Time", obj.time);
            return DataAccess.SpExecuteQuery("SpMachineUse", parameters);
        } 
        public static int Update(BLMachineUse obj)
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@Execute", "update");
            parameters[1] = new SqlParameter("@CustomerId", obj.CustomerId);
            parameters[2] = new SqlParameter("@MachineId", obj.MachineId);
            parameters[3] = new SqlParameter("@Status", obj.Status);
            parameters[4] = new SqlParameter("@Time", obj.time);
            parameters[5] = new SqlParameter("@MachineUseId", obj.MachineUseId);
            return DataAccess.SpExecuteQuery("SpMachineUse", parameters);
        }
        public static int Delete(int Id)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Execute", "delete");
            parameters[1] = new SqlParameter("@MachineUseId", Id);
            return DataAccess.SpExecuteQuery("SpMachineUse", parameters);
        } 
        public static DataTable CheckMachineStatus(int MachineId,string Time)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", "CheckMachineStatus");
            prm[1] = new SqlParameter("@MachineId", MachineId);
            prm[2] = new SqlParameter("@Time", Time);
            return DataAccess.SpGetData("SpMachineUse", prm); 
        }
        public static DataTable GetData(int? CustomerId=null,int? MachineId=null,int? MachineUseId=null)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0]=new SqlParameter  ("@Execute","select");
            parameters[1]=new SqlParameter  ("@CustomerId", CustomerId);
            parameters[2]=new SqlParameter  ("@MachineId", MachineId);
            parameters[3]=new SqlParameter  ("@MachineUseId", MachineUseId);
            return DataAccess.SpGetData("SpMachineUse", parameters);
        } 
        public static DataTable Searching(string ColumnName,string value)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0]=new SqlParameter  ("@Execute","Search");
            parameters[1]=new SqlParameter  ("@"+ColumnName, value);
            return DataAccess.SpGetData("SpMachineUse", parameters);
        } 
       
      
    }
}
