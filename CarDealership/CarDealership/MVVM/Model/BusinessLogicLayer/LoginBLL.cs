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
        LoginDAL loginDAL = new LoginDAL();

        public Client VerifyLoginClient(string email, string password)
        {
            return loginDAL.VerifyLoginClient(email, password);
        }
    }
}
