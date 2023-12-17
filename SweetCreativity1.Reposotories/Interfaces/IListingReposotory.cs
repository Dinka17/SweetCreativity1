using SweetCreativity1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetCreativity1.Reposotories.Interfaces
{
    public interface IListingReposotory : ISave
    {
        Listing Get(int id);
        IEnumerable<Listing> GetAll();
        void Add(Listing obj);
        void Update(Listing obj);
        void Delete(Listing obj);

        //int Find(int id);
    }
}