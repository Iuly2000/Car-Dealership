using CarDealership.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.EntityLayer
{
    class CreditCard : ObservableObject
    {
        private int? creditCardID;
        public int? CreditCardID
        {
            get
            {
                return creditCardID;
            }
            set
            {
                creditCardID = value;
                NotifyPropertyChanged("CreditCardID");
            }
        }


        private string brand;
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
                NotifyPropertyChanged("Brand");
            }
        }

        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                NotifyPropertyChanged("Country");
            }
        }

        private string bank;
        public string Bank
        {
            get
            {
                return bank;
            }
            set
            {
                bank = value;
                NotifyPropertyChanged("Bank");
            }
        }

        private int balance;
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
                NotifyPropertyChanged("Balance");
            }
        }
    }

}
