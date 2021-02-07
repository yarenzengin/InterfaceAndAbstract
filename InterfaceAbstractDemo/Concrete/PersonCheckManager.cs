using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;//doğrulanmış sayıyoruz
            

        }
    }
}
