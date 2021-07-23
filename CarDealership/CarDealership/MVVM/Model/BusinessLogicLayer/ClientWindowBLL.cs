using CarDealership.MVVM.Model.DataAccessLayer;
using CarDealership.MVVM.Model.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.BusinessLogicLayer
{
    class ClientWindowBLL
    {
        ClientDAL clientDAL = new ClientDAL();
        CreditCardDAL creditCardDAL = new CreditCardDAL();
        CarClientDAL carClientDAL = new CarClientDAL();
        public void ModifyClient(Client client)
        {
            clientDAL.ModifyClient(client);
        }

        public void ModifyCreditCard(CreditCard creditCard)
        {
            creditCardDAL.ModifyCreditCard(creditCard);
        }

        public void InsertCarClient(CarClient carClient)
        {
            carClientDAL.InsertCarClient(carClient);
        }
    }
}
