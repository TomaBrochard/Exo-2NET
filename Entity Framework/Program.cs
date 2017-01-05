using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDatabaseContainer dbContext = new MyDatabaseContainer())
            {
                //dbContext.Database.CreateIfNotExists(); // You know what this does
                dbContext.Person.Add(new Person()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    RegistrationDate = DateTime.Now,
                    Address = new Address()
                    {
                        Number = 36,
                        Street = "Quai des Orfèvres",
                        ZipCode = 75001,
                        City = "Paris"
                    }
                });
                dbContext.SaveChanges();
            }
        }
    }
}
