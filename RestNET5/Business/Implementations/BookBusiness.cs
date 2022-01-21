using RestNET5.Data.Converter.Implementations;
using RestNET5.Data.VO;
using RestNET5.Models;
using RestNET5.Repository;
using System.Collections.Generic;

namespace RestNET5.Business.Implementations
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        private readonly BookConverter _converter;
        public BookBusiness(IRepository<Book> context)
        {
            _repository = context;
            _converter = new BookConverter();
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public BookVO Create(BookVO book)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(book)));
        }

        public BookVO Update(BookVO book)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(book)));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
