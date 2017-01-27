using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace HelpDesk
{
    public class Employee
    {
        #region Declarations
        public int empid { get; set; }
        public string name { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        #endregion

        #region Methods
        public static ICollection<Employee> GetEmployee()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mwd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spHelpDeskGetEmployee", conn);
            List<Employee> list = new List<Employee>();
            try
            {
                Employee e = new Employee();
                e.empid = 0;
                e.name = "--select one--";
                list.Add(e);

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employee emp = new Employee();
                    emp.empid = Convert.ToInt32(rdr["ID"]);
                    emp.name = rdr["Name"].ToString();
                    list.Add(emp);
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
