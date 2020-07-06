using System;
using HoldTheMoney.Domain.Entities;

namespace HoldTheMoney.Domain.Interfaces.Services
{
    public interface IUserService
    {
        User Create(User user);
        void Update(User user);
        
    }
}
