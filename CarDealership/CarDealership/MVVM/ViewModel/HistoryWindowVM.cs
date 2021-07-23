using CarDealership.Helpers;
using CarDealership.MVVM.Model.BusinessLogicLayer;
using CarDealership.MVVM.Model.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarDealership.MVVM.ViewModel
{
    class HistoryWindowVM: ObservableObject
    {
        CarBLL carBLL = new CarBLL();
        private ObservableCollection<Car> carsSold;
        public ObservableCollection<Car> CarsSold
        {
            get
            {
                return carsSold;
            }
            set
            {
                carsSold = value;
                NotifyPropertyChanged("CarsSold");
            }
        }
        private ObservableCollection<Car> carsLoaned;
        public ObservableCollection<Car> CarsLoaned
        {
            get
            {
                return carsLoaned;
            }
            set
            {
                carsLoaned = value;
                NotifyPropertyChanged("CarsLoaned");
            }
        }
        private string startDate;
        public string StartDate
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
        private string endDate;
        public string EndDate
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
        private Car car;
        public Car Car
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
                NotifyPropertyChanged("Car");
            }
        }
        private ICommand seeCommand;
        public ICommand SeeCommand
        {
            get
            {
                if (seeCommand == null)
                {
                    seeCommand = new RelayCommand<object>(o =>
                    {

                        List<string> date=carBLL.GetDate(car);
                        StartDate = date[0];
                        EndDate = date[1];
                    });
                }
                return seeCommand;
            }
        }
    }
}
