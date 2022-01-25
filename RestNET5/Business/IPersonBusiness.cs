using RestNET5.Data.VO;
using RestNET5.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestNET5.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindByName(string firstName, string lastName);
        List<PersonVO> FindAll(); 
        PagedSearchVO<PersonVO> FindWithPagedSearch(
             string name, string sortDirection, int pageSize, int page);
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);
    }
}
