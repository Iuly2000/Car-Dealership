using CarDealership.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.EntityLayer
{
    class CarClient:ObservableObject
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

        private bool loaned;
        public bool Loaned
        {
            get
            {
                return loaned;
            }
            set
            {
                loaned = value;
                NotifyPropertyChanged("Loaned");
            }
        }

        private DateTime? startDate;
        public DateTime? StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
                NotifyPropertyChanged("StartDate");
            }
        }

        private DateTime? endDate;
        public DateTime? EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
                NotifyPropertyChanged("EndDate");
            }
        }
    }
}
