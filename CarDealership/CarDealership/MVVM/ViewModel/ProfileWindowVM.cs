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
            if (window.name.Text.Trim(' ') == "" ||
                ((bool)window.checkPass.IsChecked && window.password.Password.Trim(' ') == "") ||
                 window.email.Text == "" || window.phoneNumber.Text == "")
            {
                MessageBox.Show("Not all fields have been filled in!", "Avertizare", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            int phoneNumber;
            if (int.TryParse(window.phoneNumber.Text, out phoneNumber) == false ||
                window.phoneNumber.Text.StartsWith("00") || window.phoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Phone numbers needs to be a valid number!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

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
