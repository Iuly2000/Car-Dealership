using CarDealership.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.EntityLayer
{
    class Client:ObservableObject
    {
        private int? clientID;
        public int? ClientID
        {
            get
            {
                return clientID;
            }
            set
            {
                clientID = value;
                NotifyPropertyChanged("ClientID");
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                NotifyPropertyChanged("Email");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
                NotifyPropertyChanged("PhoneNumber");
            }
        }


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
    }
}
