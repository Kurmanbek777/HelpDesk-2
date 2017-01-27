using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace HelpDesk
{
    public class Department
    {
        #region Declarations
        public int id {get;set;}
        public string department { get; set; }
        #endregion

        #region Methods
        public static ICollection<Department> GetDepartments()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mwd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spHelpDeskGetDepartments", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Department> list = new List<Department>();
            try
            {
                Department d = new Department();
                d.id = 0;
                d.department = "--select one--";
                list.Add(d);

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Department dept = new Department();
                    dept.id = Convert.ToInt32(rdr["ID"]);
                    dept.department = rdr["Department"].ToString();
                    list.Add(dept);
                }
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
            return list;
        }
        #endregion
    }
}
