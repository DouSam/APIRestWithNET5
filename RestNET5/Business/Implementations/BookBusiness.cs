using RestNET5.Models;
using RestNET5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestNET5.Business.Implementations
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        public BookBusiness(IRepository<Book> context)
        {
            _repository = context;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
