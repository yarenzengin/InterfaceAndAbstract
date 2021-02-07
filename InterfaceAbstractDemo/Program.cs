using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager1.Save(new Customer {DateOfBirth = new DateTime(2000,9,7), FirstName = "m", LastName = "z" , NationalityId = 8868878488998});
            Console.ReadLine();
        
        
        }
    }
}
