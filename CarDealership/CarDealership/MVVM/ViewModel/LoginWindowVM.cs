using CarDealership.Helpers;
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
    class LoginWindowVM
    {
        private ICommand loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                {
                    loginCommand = new RelayCommand<LoginWindow>(Logging);
                }
                return loginCommand;
            }
        }
        private void Logging(LoginWindow window)
        {
            string email = window.txtemail.Text;
            string password = window.txtpassword.Password;

            if (email == "Admin" && password == "123")
            {
                window.Hide();
                AdminWindow admin = new AdminWindow();
                admin.ShowDialog();
            }
            else MessageBox.Show("Email si/sau parola gresite!", "Avertizare", MessageBoxButton.OK, MessageBoxImage.Warning);
            
        }

    }
}
