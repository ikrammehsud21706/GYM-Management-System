using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL
{
    internal class DataAccess
    {
       static SqlConnection con = new SqlConnection("server=DESKTOP-N2V11J1\\SQLEXPRESS;database=GymManagementSystem;integrated security=true");
        public static int SpExecuteQuery(string storeprocedure, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(storeprocedure, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            con.Open();
            int check=cmd.ExecuteNonQuery();
            con.Close();
            return check;
        }
        public static DataTable SpGetData(string storeprocedure, SqlParameter parameters)
        {
            SqlCommand cmd=new SqlCommand(storeprocedure, con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.Add(parameters);
            SqlDataAdapter adapter=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable SpGetData(string storeprocedure, SqlParameter[] parameters)
        {
            SqlCommand cmd=new SqlCommand(storeprocedure, con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adapter=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
