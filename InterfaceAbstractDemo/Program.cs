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
            customerManager1.Save(new Customer {DateOfBirth = new DateTime(1985,1,5), FirstName = "Engin", LastName = "Demiroğ" , NationalityId = 8868878998});
            Console.ReadLine();
        
        
        }
    }
}
