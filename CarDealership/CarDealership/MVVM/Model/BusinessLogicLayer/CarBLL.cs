using CarDealership.MVVM.Model.DataAccessLayer;
using CarDealership.MVVM.Model.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
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
            string Balance = System.IO.File.ReadAllText(@"..\..\bin\Debug\Balance.txt");
            if (car.Price <= int.Parse(Balance))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\bin\Debug\Balance.txt"))
                {
                    writer.WriteLine((int.Parse(Balance) - car.Price/2).ToString());
                }
            }            
            else
            {
                MessageBox.Show("Car price must be less than or equal to account balance!");
            }
            
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
        public void DeleteCar(Car car)
        {

            carDAL.DeleteCar(car);
        }
        public ObservableCollection<Car> GetCarsSold()
        {
            try
            {
                return carDAL.GetCarsSold();
            }
            catch
            {
                throw new ArgumentNullException("No cars were sold!");
            }
        }
        public ObservableCollection<Car> GetCarsSoldUser(int? id)
        {
            try
            {
                return carDAL.GetCarsSoldUser(id);
            }
            catch
            {
                throw new ArgumentNullException("You haven't bought a car!");
            }
        }
        public ObservableCollection<Car> GetCarsLoaned()
        {
            try
            {
                return carDAL.GetCarsLoaned();
            }
            catch
            {
                throw new ArgumentNullException("No cars were loaned!");
            }

        }
        public ObservableCollection<Car> GetCarsLoanedUser(int? id)
        {
            try
            {
                return carDAL.GetCarsLoanedUser(id);
            }
            catch
            {
                throw new ArgumentNullException("You haven't loaned a car!");
            }

        }
        public List<string> GetDate(Car car)
        {
            return carDAL.GetDate(car);
        }
    }
}
