using RestNET5.Models;
using System.Collections.Generic;

namespace RestNET5.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string secondName);
    }
}
