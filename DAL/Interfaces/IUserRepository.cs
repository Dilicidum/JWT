﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IUserRepository:IRepository<User>
    {
        Task<User> FindByEmailAsync(string Email); 
    }
}
