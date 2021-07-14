using CarDealership.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.EntityLayer
{
    class Car:ObservableObject
    {
        private int? carID;
        public int? CarID
        {
            get
            {
                return carID;
            }
            set
            {
                carID = value;
                NotifyPropertyChanged("CarID");
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

        private string model;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
                NotifyPropertyChanged("Model");
            }
        }

        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                NotifyPropertyChanged("Price");
            }
        }

        private string fabricationYear;
        public string FabricationYear
        {
            get
            {
                return fabricationYear;
            }
            set
            {
                fabricationYear = value;
                NotifyPropertyChanged("FabricationYear");
            }
        }

        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                NotifyPropertyChanged("Color");
            }
        }

        private string engine;
        public string Engine
        {
            get
            {
                return engine;
            }
            set
            {
                engine = value;
                NotifyPropertyChanged("Engine");
            }
        }

        private string image;
        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                NotifyPropertyChanged("Image");
            }
        }


    }
}
