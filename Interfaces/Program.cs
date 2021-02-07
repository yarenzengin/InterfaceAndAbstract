using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }
    interface IPersonManager
    {
        //unimplemented operstion
        void Add();///bu imzayı taşımak zorunda
        void Update();
    }
    //inherits - class -----------implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {//müşteri ekleme kodları
            Console.WriteLine("müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {//personel ekleme kodları
            Console.WriteLine("personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personel güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("stajer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("stajer güncellendi");
        }
    }
    class ProjectManager
    {

        public void Add(IPersonManager personManager)//hangisi gelirse o çalışsın
        {
            personManager.Add();
        }

    }
}
