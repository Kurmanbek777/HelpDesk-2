using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace HelpDesk
{
    public class HelpDesk
    {
        #region Declarations
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public int status { get; set; }
        public string comments { get; set; }
        public int severity { get; set; }
        public int department { get; set; }
        #endregion

        #region Methods
        public void Save()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mwd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spInsertHelpDeskTicket", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameterFName = new SqlParameter("@FName", SqlDbType.VarChar, 50);
            parameterFName.Value = fname;
            cmd.Parameters.Add(parameterFName);
            SqlParameter parameterLName = new SqlParameter("@LName", SqlDbType.VarChar, 50);
            parameterLName.Value = lname;
            cmd.Parameters.Add(parameterLName);
            SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            parameterEmail.Value = email;
            cmd.Parameters.Add(parameterEmail);
            SqlParameter parameterSeverity = new SqlParameter("@SeverityID", SqlDbType.Int);
            parameterSeverity.Value = severity;
            cmd.Parameters.Add(parameterSeverity);
            SqlParameter parameterStatus = new SqlParameter("@StatusID", SqlDbType.Int);
            parameterStatus.Value = status;
            cmd.Parameters.Add(parameterStatus);
            SqlParameter parameterDepartment = new SqlParameter("@DepartmentID", SqlDbType.Int);
            parameterDepartment.Value = department;
            cmd.Parameters.Add(parameterDepartment);
            SqlParameter parameterComments = new SqlParameter("@Comments", SqlDbType.VarChar, 250);
            parameterComments.Value = comments;
            cmd.Parameters.Add(parameterComments);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        #endregion
    }
}
