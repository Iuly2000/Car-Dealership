using CarDealership.MVVM.Model.DataAccessLayer;
using CarDealership.MVVM.Model.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.MVVM.Model.BusinessLogicLayer
{
    class LoginBLL
    {        
        ClientDAL clientDAL = new ClientDAL();
        CreditCardDAL creditCardDAL = new CreditCardDAL();

        public Client VerifyLoginClient(string email, string password)
        {
            return clientDAL.VerifyLoginClient(email, password);
        }

        public void InsertClient(Client client)
        {
            clientDAL.InsertClient(client);
        }

        public void InsertCreditCard(CreditCard creditCard)
        {
            creditCardDAL.InsertCreditCard(creditCard);
        }

        public int GetTheLastCreditCard()
        {
            return creditCardDAL.GetTheLastCreditCard();
        }

        public CreditCard GetCreditCard(int? creditCardID)
        {
            return creditCardDAL.GetCreditCard(creditCardID);
        }
    }
}
