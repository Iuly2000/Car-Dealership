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

        private Client client;
        public Client Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
                NotifyPropertyChanged("Client");
            }
        }

        private CreditCard creditCard;
        public CreditCard CreditCard
        {
            get
            {
                return creditCard;
            }
            set
            {
                creditCard = value;
                NotifyPropertyChanged("CreditCard");
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

        private ICommand profileCommand;
        public ICommand ProfileCommand
        {
            get
            {
                if (profileCommand == null)
                {
                    profileCommand = new RelayCommand<object>((_) => BtnProfile_Click());
                
                }
                return profileCommand;
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

        private void BtnProfile_Click()
        {
            ProfileWindow profile = new ProfileWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = profile;
            (profile.DataContext as ProfileWindowVM).Client = client;
            profile.ShowDialog();
        }
        private void BtnRefresh_Click()
        {
            ClientWindow clientWindow = new ClientWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = clientWindow;
            clientWindow.ShowDialog();
        }

        private void BtnBack_Click()
        {
            LoginWindow loginWindow = new LoginWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = loginWindow;
            loginWindow.ShowDialog();

        }
    }
}
