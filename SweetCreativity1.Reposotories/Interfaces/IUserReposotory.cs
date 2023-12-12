using SweetCreativity1.Core.Entities;

namespace SweetCreativity1.Reposotories.Interfaces
{
    public interface IUserReposotory : ISave
    {
        User Get(int id);
        IEnumerable<User> GetAll();
        void Add(User obj);
        void Update(User obj);
        void Delete(User obj);

        //int Find(int id);
    }
}