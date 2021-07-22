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
    class CreditCardDAL
    {
        public void InsertCreditCard(CreditCard creditCard)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("InsertCreditCard", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramBrand = new SqlParameter("@brand", creditCard.Brand);
                SqlParameter paramCountry = new SqlParameter("@country", creditCard.Country);
                SqlParameter paramBank = new SqlParameter("@bank", creditCard.Bank);
                SqlParameter paramBalance = new SqlParameter("@balance", creditCard.Balance);
                cmd.Parameters.Add(paramBrand);
                cmd.Parameters.Add(paramCountry);
                cmd.Parameters.Add(paramBank);
                cmd.Parameters.Add(paramBalance);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public CreditCard GetCreditCard(int? creditCardID)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("GetCreditCard", con);                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramCreditID = new SqlParameter("@credit_card_id", creditCardID);
                cmd.Parameters.Add(paramCreditID);
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                CreditCard result = new CreditCard();
                if (reader.Read())
                {
                    CreditCard creditCard = new CreditCard()
                    {
                        CreditCardID = (int?)reader[0],
                        Brand = reader.GetString(1),
                        Country = reader.GetString(2),
                        Bank = reader.GetString(3),
                        Balance = (int)reader[4]
                    };
                    result = creditCard;
                }
                return result;
            }
        }
        public int GetTheLastCreditCard()
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("GetTheLastCreditCard", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return (int)(reader[0]);
                }

                return 0;
            }
        }

        public void ModifyCreditCard(CreditCard creditCard)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyCreditCard", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@credit_Card_id", creditCard.CreditCardID);
                SqlParameter paramBrand = new SqlParameter("@brand", creditCard.Brand);
                SqlParameter paramCountry = new SqlParameter("@country", creditCard.Country);
                SqlParameter paramBank = new SqlParameter("@bank", creditCard.Bank);
                SqlParameter paramBalance = new SqlParameter("@balance", creditCard.Balance);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramBrand);
                cmd.Parameters.Add(paramCountry);
                cmd.Parameters.Add(paramBank);
                cmd.Parameters.Add(paramBalance);                
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
