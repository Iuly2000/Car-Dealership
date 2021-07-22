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

        public void ModifyClient(Client client)
        {
            clientDAL.ModifyClient(client);
        }
    }
}
