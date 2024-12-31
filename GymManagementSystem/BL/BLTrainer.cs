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
    internal class BLTrainer
    {
        public int trainerid { get; set; }
        public string trainername { get; set; }
        public string contact { get; set; }
        public string cnic { get; set; }
        public string address { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string gender { get; set; }

        public static int Save(BLTrainer obj)
        {
            SqlParameter[] prm = new SqlParameter[8];
            prm[0] = new SqlParameter("@Execute", "insert");
            prm[1] = new SqlParameter("@TrainerName", obj.trainername);
            prm[2] = new SqlParameter("@Contact", obj.contact);
            prm[3] = new SqlParameter("@CNIC", obj.cnic);
            prm[4] = new SqlParameter("@Address", obj.address);
            prm[5] = new SqlParameter("@Status", obj.status);
            prm[6] = new SqlParameter("@Type", obj.type);
            prm[7] = new SqlParameter("@Gender", obj.gender);
            return DataAccess.SpExecuteQuery("SpTrainer", prm);
        }
        public static int Update(BLTrainer obj)
        {
            SqlParameter[] prm = new SqlParameter[9];
            prm[0] = new SqlParameter("@Execute", "update");
            prm[1] = new SqlParameter("@TrainerName", obj.trainername);
            prm[2] = new SqlParameter("@Contact", obj.contact);
            prm[3] = new SqlParameter("@CNIC", obj.cnic);
            prm[4] = new SqlParameter("@Address", obj.address);
            prm[5] = new SqlParameter("@Status", obj.status);
            prm[6] = new SqlParameter("@Type", obj.type);
            prm[7] = new SqlParameter("@Gender", obj.gender);
            prm[8] = new SqlParameter("@TrainerID", obj.trainerid);
            int check= DataAccess.SpExecuteQuery("SpTrainer", prm);
            return check;
        }
        public static int Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "delete");
            prm[1] = new SqlParameter("@TrainerID", id);
            int check=DataAccess.SpExecuteQuery("SpTrainer", prm);
            return check;
        }
        public static DataTable GetData(int? TrainerId=null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0]=new SqlParameter ("@Execute", "select");
            prm[1]=new SqlParameter ("@TrainerId", TrainerId);
            return DataAccess.SpGetData("SpTrainer", prm);
        }
        public static DataTable CheckTrainer(string ColumnName,string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "select");
            prm[1] = new SqlParameter("@"+ColumnName, value);
            return DataAccess.SpGetData("SpTrainer", prm);
        }
        public static DataTable CheckTrainerInUpdate(string ColumnName, string value,int TrainerID)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", "checkTrainer");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            prm[2] = new SqlParameter("@TrainerID", TrainerID);
            return DataAccess.SpGetData("SpTrainer", prm);
        }
        public static DataTable Searching(string ColumnName, string value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", "search");
            prm[1] = new SqlParameter("@" + ColumnName, value);
            return DataAccess.SpGetData("SpTrainer", prm);
        }
    }
}
