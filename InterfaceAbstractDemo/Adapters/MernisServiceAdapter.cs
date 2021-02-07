﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName.ToUpper(),
                 customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
