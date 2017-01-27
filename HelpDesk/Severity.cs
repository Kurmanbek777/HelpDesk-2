using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace HelpDesk
{
    public class Severity
    {
        #region Declarations
        public int id { get; set; }
        public string severity { get; set; }
        #endregion

        #region Methods
        public static ICollection<Severity> GetSeverities()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mwd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spHelpDeskGetSeverities", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Severity> list = new List<Severity>();
            try
            {
                Severity s = new Severity();
                s.id = 0;
                s.severity = "--select one--";
                list.Add(s);

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Severity severity = new Severity();
                    severity.id = Convert.ToInt32(rdr["ID"]);
                    severity.severity = rdr["Severity"].ToString();
                    list.Add(severity);
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
