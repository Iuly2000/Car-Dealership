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
    class CreditCardWindowVM:ObservableObject
    {
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

        private ICommand modifyCommand;
        public ICommand ModifyCommand
        {
            get
            {
                if (modifyCommand == null)
                {
                    modifyCommand = new RelayCommand<CreditCardWindow>(ModifyCreditCard);
                }
                return modifyCommand;
            }
        }
        private void ModifyCreditCard(CreditCardWindow window)
        {
            if (window.brand.Text.Trim(' ') == "" || window.country.Text.Trim(' ') == "" ||
                 window.bank.Text == "" || window.balance.Text == "")
            {
                MessageBox.Show("Not all fields have been filled in!", "Avertizare", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            int balance;            
            if (int.TryParse(window.balance.Text, out balance) == false)
            {
                MessageBox.Show("Balance needs to be an integer!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            creditCard.Brand = window.brand.Text;            
            creditCard.Country = window.country.Text;
            creditCard.Bank = window.bank.Text;
            creditCard.Balance = balance;
            ClientWindowBLL clientWindowBLL = new ClientWindowBLL();
            clientWindowBLL.ModifyCreditCard(creditCard);
        }
    }
}
