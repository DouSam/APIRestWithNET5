using RestNET5.Data.Converter.Implementations;
using RestNET5.Data.VO;
using RestNET5.Models;
using RestNET5.Repository;
using System.Collections.Generic;

namespace RestNET5.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        private readonly PersonConverter _converter;
        public PersonBusiness(IRepository<Person> context)
        {
            _repository = context;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public PersonVO Create(PersonVO person)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(person)));
        }

        public PersonVO Update(PersonVO person)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(person)));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
