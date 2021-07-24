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
    class ClientDAL
    {
        public void InsertClient(Client client)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("InsertClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramName = new SqlParameter("@name", client.Name);                
                SqlParameter paramPassword = new SqlParameter("@password", client.Password);
                SqlParameter paramEmail= new SqlParameter("@email", client.Email);
                SqlParameter paramPhoneNumber = new SqlParameter("@phone_number", client.PhoneNumber);
                SqlParameter paramCreditCardID = new SqlParameter("@credit_card_id", client.CreditCardID);                
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramPassword);
                cmd.Parameters.Add(paramEmail);
                cmd.Parameters.Add(paramPhoneNumber);
                cmd.Parameters.Add(paramCreditCardID);                
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

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

        public void ModifyClient(Client client)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@client_id", client.ClientID);
                SqlParameter paramName = new SqlParameter("@name", client.Name);
                SqlParameter paramPassword = new SqlParameter("@password", client.Password);
                SqlParameter paramEmail = new SqlParameter("@email", client.Email);
                SqlParameter paramPhoneNumber = new SqlParameter("@phone_number", client.PhoneNumber);
                SqlParameter paramCreditCardID = new SqlParameter("@credit_card_id", client.CreditCardID);                
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramPassword);
                cmd.Parameters.Add(paramEmail);
                cmd.Parameters.Add(paramPhoneNumber);
                cmd.Parameters.Add(paramCreditCardID);                
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DecreaseBalance(int? clientId, int price)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("DecreaseBalance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@client_id", clientId);
                SqlParameter paramPrice = new SqlParameter("@price", price);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramPrice);              
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public int GetBalance(int? clientId)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("GetBalance", con);
                int result=-1;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", clientId);
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = int.Parse(reader[0].ToString());
                }
                reader.Close();
                return result;
            }
        }
    }
}
