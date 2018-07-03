using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccess
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        public DataSet AL_bind()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public void insert_data(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Personas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public void update_data(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Personas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}
