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
    class ProfileWindowVM : ObservableObject
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
        private void ModifyClient(ProfileWindow window)
        {
            client.Name = window.name.Text;
            if ((bool)window.checkPass.IsChecked)
                client.Password = window.password.Password;
            client.Email = window.email.Text;
            client.PhoneNumber = window.phoneNumber.Text;
            ClientWindowBLL clientWindowBLL = new ClientWindowBLL();
            clientWindowBLL.ModifyClient(client);
        }
    }
}
