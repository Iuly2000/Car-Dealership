using CarDealership.Helpers;
using CarDealership.MVVM.Model.BusinessLogicLayer;
using CarDealership.MVVM.Model.EntityLayer;
using CarDealership.MVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
        private ClientWindowBLL clientWindowBLL = new ClientWindowBLL();
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

        private ICommand creditCardCommand;
        public ICommand CreditCardCommand
        {
            get
            {
                if (creditCardCommand == null)
                {
                    creditCardCommand = new RelayCommand<object>((_) => BtnCreditCard_Click());

                }
                return creditCardCommand;
            }
        }

        private ICommand buyCarCommand;
        public ICommand BuyCarCommand
        {
            get
            {
                if (buyCarCommand == null)
                {
                    buyCarCommand = new RelayCommand<Car>(BtnBuyCar_Click);

                }
                return buyCarCommand;
            }
        }

        private ICommand loanCarCommand;
        public ICommand LoanCarCommand
        {
            get
            {
                if (loanCarCommand == null)
                {
                    loanCarCommand = new RelayCommand<ClientWindow>(BtnLoanCar_Click);

                }
                return loanCarCommand;
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
            ProfileWindow profileWindow = new ProfileWindow();
            (profileWindow.DataContext as ProfileWindowVM).Client = client;
            profileWindow.ShowDialog();
        }

        private void BtnCreditCard_Click()
        {
            CreditCardWindow creditCardWindow = new CreditCardWindow();
            (creditCardWindow.DataContext as CreditCardWindowVM).CreditCard = creditCard;
            creditCardWindow.ShowDialog();
        }

        private ICommand historyCommand;
        public ICommand HistoryCommand
        {
            get
            {
                if (historyCommand == null)
                {
                    historyCommand = new RelayCommand<object>(o =>
                    {
                        HistoryWindow historyWindow = new HistoryWindow();
                        HistoryWindowVM historyWindowContext = historyWindow.DataContext as HistoryWindowVM;
                        historyWindow.Show();
                        historyWindowContext.CarsSold = carBLL.GetCarsSoldUser(Client.ClientID);
                        historyWindowContext.CarsLoaned = carBLL.GetCarsLoanedUser(Client.ClientID);
                    });
                }
                return historyCommand;
            }
        }

        private void BtnBuyCar_Click(Car car)
        {
            if (car == null)
            {
                MessageBox.Show("You have to select a car!");
                return;
            }

            CarClient carClient = new CarClient()
            {
                ClientID = client.ClientID,
                CarID = car.CarID,
                Loaned = false,
                StartDate = null,
                EndDate = null
            };
            if (car.Price <= CreditCard.Balance)
                clientWindowBLL.InsertCarClient(carClient);
            else
            {
                MessageBox.Show("You don't have the right amount of money to buy this car!");
                return;
            }
            clientWindowBLL.DecreaseBalance(client.ClientID, car.Price);
            CreditCard.Balance = clientWindowBLL.GetBalance(client.ClientID);
            string Balance = System.IO.File.ReadAllText(@"..\..\bin\Debug\Balance.txt");            
            using (StreamWriter writer = new StreamWriter(@"..\..\bin\Debug\Balance.txt"))
            {
                writer.WriteLine((int.Parse(Balance) + car.Price).ToString());
            }
            
        }

        private void BtnLoanCar_Click(ClientWindow clientWindow)
        {
            Car car = (clientWindow.grdCars.SelectedItem as Car);
            if (car == null)
            {
                MessageBox.Show("You have to select a car!");
                return;
            }
            DateTime? start = clientWindow.startDate.SelectedDate;
            DateTime? end = clientWindow.endDate.SelectedDate;
            if(start==null || end==null)
            {
                MessageBox.Show("You have to select both the start and end period loan!");
                return;
            }

            CarClient carClient = new CarClient()
            {
                ClientID = client.ClientID,
                CarID = car.CarID,
                Loaned = true,
                StartDate = start,
                EndDate = end
            };

            clientWindowBLL.InsertCarClient(carClient);
        }
        private void BtnRefresh_Click()
        {
            ClientWindow clientWindow = new ClientWindow();
            ClientWindowVM currentWindowDataContext = (Application.Current.MainWindow.DataContext as ClientWindowVM);
            ClientWindowVM clientWindowDataContext = (clientWindow.DataContext as ClientWindowVM);
            clientWindowDataContext.Client = currentWindowDataContext.client;
            clientWindowDataContext.CreditCard = currentWindowDataContext.creditCard;
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
