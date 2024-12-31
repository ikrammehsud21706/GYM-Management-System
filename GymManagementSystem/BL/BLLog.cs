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
    public class BLLog
    {

        public int LogId { get; set; }
        public int UserId { get; set; }
        public string Log { get; set; }
        public DateTime dateTime { get; set; }
        public static void Save(BLLog obj)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Execute", ActionType.Insert);
            prm[1] = new SqlParameter("@UserId", obj.UserId);
            prm[2] = new SqlParameter("@Log", obj.Log);
            prm[3] = new SqlParameter("@DateTime", obj.dateTime);
            DataAccess.SpExecuteQuery("SpLog", prm);
        }
        public static void Delete(int LogId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", ActionType.Delete);
            prm[1] = new SqlParameter("@LogId", LogId);
            DataAccess.SpExecuteQuery("SpLog", prm);
        }
        public static DataTable GetData()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Execute", ActionType.Select);
            return DataAccess.SpGetData("SpLog", prm);
        }
    }
}
