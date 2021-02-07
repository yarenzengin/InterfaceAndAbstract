using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
    //somut sınıflarda inheritance veya implatamasyon almıyorsa ileride nesnellik zafiyeti yaşanır.Bu tip kurallar için IEntity implemente ettik
    public class Customer:IEntity//vt nesnesi old. göstermek için
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
