using CarDealership.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.EntityLayer
{
    class Vehicle: ObservableObject
    {
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
    }
}
