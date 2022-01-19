using RestNET5.Models;
using System.Collections.Generic;

namespace RestNET5.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();

        Person Update(Person person);
        void Delete(long id);
    }
}
