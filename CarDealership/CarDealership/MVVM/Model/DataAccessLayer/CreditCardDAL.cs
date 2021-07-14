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
    }
}
