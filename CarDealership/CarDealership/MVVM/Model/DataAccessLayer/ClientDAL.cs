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
    }
}
