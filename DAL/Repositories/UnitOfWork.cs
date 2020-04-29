using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private ApplicationDbContext context;
        private UserRepository userRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IUserRepository UserRepository => userRepository = userRepository ?? new UserRepository(context);

        public async Task<int> Commit()
        {
            return await context.SaveChangesAsync();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
