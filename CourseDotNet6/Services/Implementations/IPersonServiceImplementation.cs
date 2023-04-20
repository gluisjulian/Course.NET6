using CourseDotNet6.Controllers;
using CourseDotNet6.Model;
using System.Net;
using System.Reflection;

namespace CourseDotNet6.Services.Implementations
{
    public class IPersonServiceImplementation : IPersonService
    {

        public List<Person> FindAll()
        {
            return new List<Person>()
            {
               new Person()
               {
                    Id = 1,
                    FirstName = "Gabriel",
                    LastName = "Julian",
                    Address = "Marilia - SP - Brasil",
                    Gender = "Male"
               },
               new Person()
               {
                   Id = 2,
                FirstName = "Edilson",
                LastName = "Julian",
                Address = "Marilia - SP - Brasil",
                Gender = "Male"
               },
               new Person()
               {
                   Id = 3,
                    FirstName = "Carolina",
                    LastName = "Julian",
                    Address = "Itatiba - SP - Brasil",
                    Gender = "Female"
               },
               new Person()
               {
                   Id = 4,
                    FirstName = "Silvana",
                    LastName = "Julian",
                    Address = "Marilia - SP - Brasil",
                    Gender = "Female"
               }
            };
            
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Gabriel",
                LastName = "Julian",
                Address = "Marilia - SP - Brasil",
                Gender = "Male"
            };
        }

        public Person Create(Person person)
        {
            return person;
        }

        public Person Update(Person person)
        {
            return person;
        }

        public Person Delete(long id)
        {
            return null;
        }

    }
}
