using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class UserRepository:Repository<User>,IUserRepository
    { 
        private ApplicationDbContext context 
        {
            get { return Context as ApplicationDbContext; }
        }
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public async Task<User> FindByEmailAsync(string Email)
        {
            User user = await context.Users.Where(c => c.Email == Email).FirstOrDefaultAsync();
            return user;
        }
    }
}
