using SweetCreativity1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetCreativity1.Reposotories.Interfaces
{
    public interface IConstructionReposotory : ISave
    {
        Construction Get(int id);
        IEnumerable<Construction> GetAll();
        void Add(Construction obj);
        void Update(Construction obj);

        // Додайте новий метод для отримання деталей Construction
        Construction GetConstructionDetails(int id);
    }
}