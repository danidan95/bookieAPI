using bookieAPI.DTOs;
using bookieAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookieAPI.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly BookContext _context;

        public UserRepository(BookContext context)
        {
            _context = context;
        }

        public async Task<User> Create(User user)
        {
            _context.Users.Add(user);
            await  _context.SaveChangesAsync();
            return user;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Login(LoginDTO loginDTO)
        {
            var user = await  _context.Users.FirstOrDefaultAsync(x=>x.Username==loginDTO.Username && x.Password ==loginDTO.Password);
            if (user != null) return true;
            //foreach(var user in users)
            //{
            //    if(user.Username==loginDTO.Username && user.Password == loginDTO.Password)
            //    {
            //        return true;
            //    }
            //}
            return false;
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
