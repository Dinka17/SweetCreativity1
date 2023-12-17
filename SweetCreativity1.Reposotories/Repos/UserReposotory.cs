using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SweetCreativity1.Core.Context;
using SweetCreativity1.Core.Entities;
using SweetCreativity1.Repositories.DTOs.User;
using SweetCreativity1.Reposotories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetCreativity1.Reposotories.Repos
{
    public class UserReposotory : IUserReposotory
    {

        private SweetCreativity1Context _context;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserReposotory(SweetCreativity1Context context,
           UserManager<User> userManager,
           RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            _context = context;
        }

        public async Task<string> Create(UserCreateDto obj)
        {
            var newUser = new User
            {
                FullName = obj.FullName,
                Email = obj.Email,
                UserName = obj.Email,
                NormalizedEmail = obj.Email.ToUpper(),
                NormalizedUserName = obj.Email.ToUpper(),
                EmailConfirmed = true
            };

            await userManager.CreateAsync(newUser, obj.Password);

            return _context.Users.First(x => x.Email == obj.Email).Id;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> Get(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<UserReadDto>> GetAll()
        {
            var users = _context.Users.ToList();
            var usersDto = new List<UserReadDto>();

            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);
                usersDto.Add(
                    new UserReadDto
                    {
                        Id = user.Id,
                        Email = user.Email,
                        FullName = user.FullName,
                        IsConfirmed = user.EmailConfirmed,
                        Roles = roles.ToList()
                    });
            }

            return usersDto;
        }

        public async Task Update(UserUpdateDto model, string[] roles)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == model.Id);

            if (user.Email != model.Email)
            {
                user.Email = model.Email;
                user.UserName = model.Email;
                user.NormalizedUserName = model.Email.ToUpper();
                user.NormalizedEmail = model.Email.ToUpper();
            }

        /*    if (user.FullName != model.FullName) user.FullName = model.FullName;*/ ///////????
            if (user.EmailConfirmed != model.IsConfirmed) user.EmailConfirmed = model.IsConfirmed;

            if ((await userManager.GetRolesAsync(user)).Any())
            {
                await userManager.RemoveFromRolesAsync(user, await userManager.GetRolesAsync(user));
            }

            if (roles.Any())
            {
                await userManager.AddToRolesAsync(user, roles.ToList());
            }

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<string?>> GetRoles()
        {
            return _context.Roles.Select(x => x.Name).ToList();
        }
    }

}