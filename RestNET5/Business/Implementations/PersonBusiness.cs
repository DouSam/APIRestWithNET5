using RestNET5.Models;
using RestNET5.Models.Context;
using RestNET5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestNET5.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        public PersonBusiness(IRepository<Person> context)
        {
            _repository = context;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
