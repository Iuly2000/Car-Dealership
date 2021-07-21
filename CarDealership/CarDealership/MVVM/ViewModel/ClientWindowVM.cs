using CarDealership.Helpers;
using CarDealership.MVVM.Model.BusinessLogicLayer;
using CarDealership.MVVM.Model.EntityLayer;
using CarDealership.MVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarDealership.MVVM.ViewModel
{
    class ClientWindowVM : ObservableObject
    {
        private CarBLL carBLL = new CarBLL();
        public ClientWindowVM()
        {
            Cars = carBLL.FillDataGrid();
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
        private void BtnRefresh_Click()
        {
            ClientWindow client = new ClientWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = client;
            client.ShowDialog();
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
