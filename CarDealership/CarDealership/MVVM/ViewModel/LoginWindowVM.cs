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

        private ICommand signUpCommand;
        public ICommand SignUpCommand
        {
            get
            {
                if (signUpCommand == null)
                {
                    signUpCommand = new RelayCommand<object>(o =>
                    {
                        SignUpWindow signUpWindow = new SignUpWindow();
                        Application.Current.MainWindow = signUpWindow;                        
                        signUpWindow.ShowDialog();
                    });
                }
                return signUpCommand;
            }
        }

        
        private void Logging(LoginWindow window)
        {
            string email = window.txtemail.Text;
            string password = window.txtpassword.Password;
            LoginBLL loginBLL = new LoginBLL();
            Client client = loginBLL.VerifyLoginClient(email, password);

            if (email == "Admin" && password == "123")
            {
                
                AdminWindow adminWindow = new AdminWindow();
                Application.Current.MainWindow = adminWindow;
                window.Close();
                adminWindow.ShowDialog();
            }            
            else if (client.ClientID != null)
            {
                ClientWindow clientWindow = new ClientWindow();
                Application.Current.MainWindow = clientWindow;
                window.Close();
                clientWindow.ShowDialog();
            }
            else MessageBox.Show("Email si/sau parola gresite!", "Avertizare", MessageBoxButton.OK, MessageBoxImage.Warning);
            
        }

    }
}
