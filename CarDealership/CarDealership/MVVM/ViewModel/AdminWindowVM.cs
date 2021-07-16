using CarDealership.Helpers;
using CarDealership.MVVM.Model.BusinessLogicLayer;
using CarDealership.MVVM.Model.EntityLayer;
using CarDealership.MVVM.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarDealership.MVVM.ViewModel
{
    class AdminWindowVM : ObservableObject
    {
        public CarBLL carBLL = new CarBLL();
        public AdminWindowVM()
        {
            Brands = carBLL.GetAllBrands();
            Cars=carBLL.FillDataGrid();
        }

        private static int balance;
        public static int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
               
            }
        }


        private Car car = new Car();
        public Car Car
        {
            get { return car; }
            set
            {
                car = Car;               
                NotifyPropertyChanged("Car");
            }
        }

        private ObservableCollection<Car> cars;
        public ObservableCollection<Car> Cars
        {
            get
            {
                return cars;
            }
            set
            {
                cars = value;
                NotifyPropertyChanged("Cars");
            }
        }

        

        private ObservableCollection<string> brands;
        public ObservableCollection<string> Brands
        {
            get
            {
                return brands;
            }
            set
            {
                brands = value;
                NotifyPropertyChanged("Brands");
            }
        }

        public void BtnImage_Click()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            dynamic result = fileDialog.ShowDialog();
            if (result == true)
            {
                car.Image = fileDialog.FileName;
            }
        }
        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    
                    addCommand = new RelayCommand<object>((_) => carBLL.InsertCar(car));

                }
                return addCommand;
            }
        }
        private ICommand imageCommand;
        public ICommand ImageCommand
        {
            get
            {
                if (imageCommand == null)
                {
                    imageCommand = new RelayCommand<object>((_) => BtnImage_Click());
                }
                return imageCommand;
            }
        }
        private ICommand backCommand;
        public ICommand BackCommand
        {
            get
            {
                if (backCommand == null)
                {
                    backCommand = new RelayCommand<object>((_) => BtnBack_Click());
                }
                return backCommand;
            }
        }
        private ICommand refreshCommand;
        public ICommand RefreshCommand
        {
            get
            {
                if (refreshCommand == null)
                {
                    refreshCommand = new RelayCommand<object>((_) => BtnRefresh_Click());
                }
                return refreshCommand;
            }
        }
        private ICommand modifyCommand;
        public ICommand ModifyCommand
        {
            get
            {
                if (modifyCommand == null)
                {
                    modifyCommand = new RelayCommand<Car>(carBLL.ModifyCar);
                }
                return modifyCommand;
            }
        }

        

        private void BtnRefresh_Click()
        {
            AdminWindow admin = new AdminWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = admin;
            admin.ShowDialog();
        }

        private void BtnBack_Click()
        {
            LoginWindow login = new LoginWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = login;
            login.ShowDialog();
            
        }
    }
}
