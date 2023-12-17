using SweetCreativity1.Core.Entities;
using SweetCreativity1.Repositories.DTOs.User;

namespace SweetCreativity1.Reposotories.Interfaces
{
    public interface IUserReposotory 
    {
        Task<User> Get(string id);
        Task<IEnumerable<UserReadDto>> GetAll();
        Task<string> Create(UserCreateDto obj);
        Task Update(UserUpdateDto obj, string[] roles);
        Task<IEnumerable<string>> GetRoles();
        void Delete(string id);

    }
}