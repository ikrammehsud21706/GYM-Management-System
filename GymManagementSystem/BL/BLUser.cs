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
    internal class BLUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FIrstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Cnic { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public string OTP { get; set; }
        public static int Save(BLUser obj)
        {
            SqlParameter[] prm = new SqlParameter[12];
            prm[0] = new SqlParameter("@Execute", ActionType.Insert);
            prm[1] = new SqlParameter("@UserName", obj.UserName);
            prm[2] = new SqlParameter("@FirstName", obj.FIrstName);
            prm[3] = new SqlParameter("@LastName", obj.LastName);
            prm[4] = new SqlParameter("@Email", obj.Email);
            prm[5] = new SqlParameter("@Contact", obj.Contact);
            prm[6] = new SqlParameter("@Cnic", obj.Cnic);
            prm[7] = new SqlParameter("@Role", obj.Role);
            prm[8] = new SqlParameter("@Password", obj.Password);
            prm[9] = new SqlParameter("@Address", obj.Address);
            prm[10] = new SqlParameter("@Status", obj.Status);
            prm[11] = new SqlParameter("@OTP", "null");
           return DataAccess.SpExecuteQuery("SpUser", prm);
        }
        public static int Update(BLUser obj)
        {
            SqlParameter[] prm = new SqlParameter[13];
            prm[0] = new SqlParameter("@Execute", ActionType.Update);
            prm[1] = new SqlParameter("@UserName", obj.UserName);
            prm[2] = new SqlParameter("@FirstName", obj.FIrstName);
            prm[3] = new SqlParameter("@LastName", obj.LastName);
            prm[4] = new SqlParameter("@Email", obj.Email);
            prm[5] = new SqlParameter("@Contact", obj.Contact);
            prm[6] = new SqlParameter("@Cnic", obj.Cnic);
            prm[7] = new SqlParameter("@Role", obj.Role);
            prm[8] = new SqlParameter("@Password", obj.Password);
            prm[9] = new SqlParameter("@Address", obj.Address);
            prm[10] = new SqlParameter("@Status", obj.Status);
            prm[11] = new SqlParameter("@OTP", "null");
            prm[12] = new SqlParameter("@UserID", obj.UserID);
           return DataAccess.SpExecuteQuery("SpUser", prm);
        }
        public static int Delete(int UserID)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", ActionType.Delete);
            prm[1] = new SqlParameter("@UserID", UserID);
            return DataAccess.SpExecuteQuery("SpUser", prm);
        }
        public static DataTable GetData()
        {
            SqlParameter prm = new SqlParameter("@Execute", ActionType.Select);
            return DataAccess.SpGetData("SpUser", prm);
        }
        //public static DataTable SearchingContact(string Contact)
        //{
        //    SqlParameter[] prm = new SqlParameter[2];
        //    prm[0] = new SqlParameter("@Execute", 5);
        //    prm[1] = new SqlParameter("@Contact", Contact);
        //    return DataAccess.SpGetData("SpUser", prm);
        //}
        //public static DataTable SearchingUserName(string UserName)
        //{
        //    SqlParameter[] prm = new SqlParameter[2];
        //    prm[0] = new SqlParameter("@Execute", 5);
        //    prm[1] = new SqlParameter("@UserName", UserName);
        //    return DataAccess.SpGetData("SpUser", prm);
        //}
        //public static DataTable SearchingEmail(string Email)
        //{
        //    SqlParameter[] prm = new SqlParameter[2];
        //    prm[0] = new SqlParameter("@Execute", 5);
        //    prm[1] = new SqlParameter("@Email", Email);
        //    return DataAccess.SpGetData("SpUser", prm);
        //}
        //public static DataTable SearchingCnic(string Cnic)
        //{
        //    SqlParameter[] prm = new SqlParameter[2];
        //    prm[0] = new SqlParameter("@Execute", 5);
        //    prm[1] = new SqlParameter("@Cnic", Cnic);
        //    return DataAccess.SpGetData("SpUser", prm);
        //}
        public static DataTable Searching(string ColumnName,string Value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", 5);
            prm[1] = new SqlParameter("@"+ColumnName, Value);
            return DataAccess.SpGetData("SpUser", prm);
        }
        public static DataTable CheckUser(string ColumnName,string Value)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", 4);
            prm[1] = new SqlParameter("@"+ColumnName, Value);
            return DataAccess.SpGetData("SpUser", prm);
        }
        public static DataTable CheckUserInUpdate(string ColumnName,string Value,int UserId)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", 6);
            prm[1] = new SqlParameter("@UserId", UserId);
            prm[2] = new SqlParameter("@"+ColumnName, Value);
            return DataAccess.SpGetData("SpUser", prm);
        }
        public static DataTable Login(string value)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Execute", 7);
            prm[1] = new SqlParameter("@UserName", value);
            prm[2] = new SqlParameter("@Contact", value);
            prm[3] = new SqlParameter("@Email", value);
            return DataAccess.SpGetData("SpUser", prm);
        }
        public static DataTable Login(string value,string Password)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Execute", 8);
            prm[1] = new SqlParameter("@UserName", value);
            prm[2] = new SqlParameter("@Contact", value);
            prm[3] = new SqlParameter("@Email", value);
            prm[4] = new SqlParameter("@Password", Password);
            return DataAccess.SpGetData("SpUser", prm);
        }
        public static DataTable ChangePassword(string Email)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Execute", 9);
            prm[1] = new SqlParameter("@Email", Email);
            return DataAccess.SpGetData("SpUser", prm);
        }
        public static DataTable ChangePassword(string Email,string password)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", 10);
            prm[1] = new SqlParameter("@Email", Email);
            prm[2] = new SqlParameter("@Password", password);
            return DataAccess.SpGetData("SpUser", prm);
        }
        public static void UpdatePassword(string password, string Email)
        { 
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", 11);
            prm[1] = new SqlParameter("@Email", Email);
            prm[2] = new SqlParameter("@Password", password);
            DataAccess.SpExecuteQuery("SpUser", prm);
        }
        public static DataTable ForgetPassword(string Email,string OTP) 
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", 12);
            prm[1] = new SqlParameter("@Email", Email);
            prm[2] = new SqlParameter("@OTP", OTP);
            return DataAccess.SpGetData("SpUser", prm);
        }
        public static int GenerateOTP(string Email,string OTP)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Execute", 13);
            prm[1] = new SqlParameter("@Email", Email);
            prm[2] = new SqlParameter("@OTP", OTP);
           int check= DataAccess.SpExecuteQuery("SpUser", prm);
            return check;
        }
    }
}
