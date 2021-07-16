using CarDealership.MVVM.Model.DataAccessLayer;
using CarDealership.MVVM.Model.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarDealership.MVVM.Model.BusinessLogicLayer
{
    class CarBLL
    {
        CarDAL carDAL = new CarDAL();
        public void InsertCar(Car car)
        {
            try
            {
                carDAL.InsertCar(car);
            }
            catch
            {
                MessageBox.Show("All fields require values!");
            }
            //if (car.Brand == "" || car.Model == "" || car.Price == 0 || car.FabricationYear == "" || car.Color == "" || car.Engine == "" || car.Image == null)
            //{
            //    //throw new Exception("All fields require values!");
            //    MessageBox.Show("All fields require values!");
            //    return;
            //}
          
        }
        public ObservableCollection<string> GetAllBrands()
        {
            return carDAL.GetAllBrands();
        }
        public ObservableCollection<Car> FillDataGrid()
        {
            return carDAL.FillDataGrid();
        }
        public void ModifyCar(Car car)
        {
          
            carDAL.ModifyCar(car);
        }
    }
}
