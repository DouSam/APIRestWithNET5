using RestNET5.Models;
using System.Collections.Generic;

namespace RestNET5.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }
            return people;
        }

        private static Person MockPerson(int i) => new Person
        {
            Id = i,
            Name = "Douglas " + i,
            LastName = "Samuel",
            Address = "Claudio rua",
            Gender = "Male"
        };

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(double id)
        {

        }

        public Person FindByID(double id)
        {
            return new Person
            {
                Id = 1,
                Name = "Douglas",
                LastName = "Samuel",
                Address = "Claudio rua",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
