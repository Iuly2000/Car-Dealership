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
    class SignUpWindowVM
    {
        private ICommand signUpCommand;
        public ICommand SignUpCommand
        {
            get
            {
                if (signUpCommand == null)
                {
                    signUpCommand = new RelayCommand<SignUpWindow>(CreateAccount);
                }
                return signUpCommand;
            }
        }

        private void CreateAccount(SignUpWindow window)
        {
            if (window.brand.Text.Trim(' ') == "" || window.country.Text.Trim(' ') == ""
                || window.bank.Text.Trim(' ') == "" || window.balance.Text.Trim(' ') == ""
                || window.name.Text.Trim(' ') == "" || window.email.Text.Trim(' ') == "" ||
                window.password.Password.Trim(' ') == "" || window.phoneNumber.Text.Trim(' ') == "")
                MessageBox.Show("Not all fields have been filled in!", "Avertizare", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {                
                int balance;
                
                if (int.TryParse(window.balance.Text, out balance) == false)
                {
                    MessageBox.Show("Balance needs to be an integer!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                long phoneNumber;
                if (long.TryParse(window.phoneNumber.Text, out phoneNumber) == false||
                    window.phoneNumber.Text.StartsWith("00")|| window.phoneNumber.Text.Length!=10)
                {
                    MessageBox.Show("Phone numbers needs to be a valid number!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                LoginBLL loginBLL = new LoginBLL();
                CreditCard creditCard = new CreditCard()
                {
                    Brand = window.brand.Text,
                    Country = window.country.Text,
                    Bank = window.bank.Text,
                    Balance = balance
                };
                loginBLL.InsertCreditCard(creditCard);

                Client client = new Client()
                {
                    Name = window.name.Text,
                    Email = window.email.Text,
                    Password = window.password.Password,
                    PhoneNumber = window.phoneNumber.Text,
                    CreditCardID = loginBLL.GetTheLastCreditCard()
                };
                loginBLL.InsertClient(client);

                window.Close();
            }
        }
    }
}
