using CarDealership.MVVM.Model.DataAccessLayer;
using CarDealership.MVVM.Model.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.BusinessLogicLayer
{
    class CarBLL
    {
        CarDAL carDAL = new CarDAL();
        public void InsertCar(Car car)
        {
            carDAL.InsertCar(car);
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
