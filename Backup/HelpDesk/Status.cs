using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace HelpDesk
{
    public class Status
    {
        #region Declarations
        public string status {get;set;}
        public int id {get;set;}
        #endregion

        #region Methods
        public static ICollection<Status> GetStatuses()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mwd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spHelpDeskGetStatuses", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Status> list = new List<Status>();
            try
            {
                Status s = new Status();
                s.id = 0;
                s.status = "--select one--";
                list.Add(s);

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Status status = new Status();
                    status.id = Convert.ToInt32(rdr["ID"]);
                    status.status = rdr["Status"].ToString();
                    list.Add(status);
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
