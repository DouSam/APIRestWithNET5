using RestNET5.Models;
using System.Collections.Generic;

namespace RestNET5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(double id);
        List<Person> FindAll();

        Person Update(Person person);
        void Delete(double id);
    }
}
