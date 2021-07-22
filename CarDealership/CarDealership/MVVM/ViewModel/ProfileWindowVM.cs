using CarDealership.Helpers;
using CarDealership.MVVM.Model.BusinessLogicLayer;
using CarDealership.MVVM.Model.EntityLayer;
using CarDealership.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarDealership.MVVM.ViewModel
{
    class ProfileWindowVM:ObservableObject
    {
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

        private ICommand modifyCommand;
        public ICommand ModifyCommand
        {
            get
            {
                if (modifyCommand == null)
                {
                    modifyCommand = new RelayCommand<ProfileWindow>(ModifyClient);
                }
                return modifyCommand;
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

        private void BtnBack_Click()
        {
            ClientWindow clientWindow = new ClientWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = clientWindow;
            LoginBLL loginBLL = new LoginBLL();
            ClientWindowVM clientWindowContext = (clientWindow.DataContext as ClientWindowVM);
            clientWindowContext.Client = client;
            clientWindowContext.CreditCard = loginBLL.GetCreditCard(client.CreditCardID);
            clientWindow.ShowDialog();
        }

        private void ModifyClient(ProfileWindow window)
        {
            client.Name = window.name.Text;
            client.Password = window.password.Password;
            client.Email = window.email.Text;
            client.PhoneNumber = window.phoneNumber.Text;
            ClientWindowBLL clientWindowBLL = new ClientWindowBLL();
            clientWindowBLL.ModifyClient(client);
        }
    }
}
