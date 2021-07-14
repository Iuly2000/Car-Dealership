﻿using CarDealership.MVVM.Model.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.DataAccessLayer
{
    class CarDAL
    {
        public void InsertCar(Car car)
        {
            using (SqlConnection con = HelperDAL.Connection)
            {
                SqlCommand cmd = new SqlCommand("InsertCar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramBrand = new SqlParameter("@brand", car.Brand);
                SqlParameter paramModel = new SqlParameter("@model", car.Model);
                SqlParameter paramPrice = new SqlParameter("@price", car.Price);
                SqlParameter paramYear = new SqlParameter("@year", car.FabricationYear);
                SqlParameter paramColor = new SqlParameter("@color", car.Color);
                SqlParameter paramEngine = new SqlParameter("@engine", car.Engine);
                SqlParameter paramImage = new SqlParameter("@image", car.Image);
                cmd.Parameters.Add(paramBrand);
                cmd.Parameters.Add(paramModel);
                cmd.Parameters.Add(paramPrice);
                cmd.Parameters.Add(paramYear);
                cmd.Parameters.Add(paramColor);
                cmd.Parameters.Add(paramEngine);
                cmd.Parameters.Add(paramImage);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public ObservableCollection<string> GetAllBrands()
        {
            SqlConnection con = HelperDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllBrands", con);
                ObservableCollection<string> result = new ObservableCollection<string>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(1));
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
    }
}