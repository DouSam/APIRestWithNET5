using RestNET5.Models;
using RestNET5.Models.BaseModel;
using System.Collections.Generic;

namespace RestNET5.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        List<T> FindWithPagedSearch(string query);
        int GetCount(string query);
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
