using CarDealership.MVVM.Model.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.DataAccessLayer
{
    class LoginDAL
    {

        public Client VerifyLoginClient(string email, string password)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("VerifyLoginClient", con);
                Client result = new Client();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramEmail = new SqlParameter("@email", email);
                SqlParameter paramPassword = new SqlParameter("@password", password);
                cmd.Parameters.Add(paramEmail);
                cmd.Parameters.Add(paramPassword);
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Client c = new Client();
                    c.ClientID = (int)(reader[0]);
                    c.Name = reader.GetString(1);
                    c.Password = reader.GetString(2);
                    c.Email = reader.GetString(3);                  
                    c.PhoneNumber = reader.GetString(4);
                    c.CreditCardID = (int)(reader[5]);
                    result = c;
                }
                reader.Close();
                return result;
            }
        }
    }
}
