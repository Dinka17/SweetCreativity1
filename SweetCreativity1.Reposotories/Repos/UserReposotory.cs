using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SweetCreativity1.Core.Context;
using SweetCreativity1.Core.Entities;
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
        public UserReposotory(SweetCreativity1Context context)
        {
            _context = context;
        }
        public void Add(User obj)
        {
            _context.Users.Add(obj);
            Save();
        }

        public void Delete(User obj)
        {
            _context.Set<User>().Remove(obj);
            Save();
        }

        public User Get(int id)
        {
           return _context.Users.Find(id);
            //return _context.Set<Listing>().Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(User obj)
        {
            _context.Users.Update(obj);
        }
    }
}