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
    class CarClientDAL
    {

        public void InsertCarClient(CarClient carClient)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("InsertCar_Client", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramClientID = new SqlParameter("@client_id", carClient.ClientID);
                SqlParameter paramCarID = new SqlParameter("@car_id", carClient.CarID);
                SqlParameter paramLoaned = new SqlParameter("@loaned", carClient.Loaned);     
                
                SqlParameter paramStartDate = new SqlParameter();
                paramStartDate.ParameterName = "@start_date";
                if (carClient.StartDate == null)
                {
                    paramStartDate.Value = DBNull.Value;
                }
                else
                {
                    paramStartDate.Value = carClient.StartDate;
                }

                SqlParameter paramEndDate = new SqlParameter();
                paramEndDate.ParameterName = "@end_date";
                if (carClient.EndDate == null)
                {
                    paramEndDate.Value = DBNull.Value;
                }
                else
                {
                    paramEndDate.Value = carClient.EndDate;
                }

                cmd.Parameters.Add(paramClientID);
                cmd.Parameters.Add(paramCarID);
                cmd.Parameters.Add(paramLoaned);
                cmd.Parameters.Add(paramStartDate);
                cmd.Parameters.Add(paramEndDate);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
