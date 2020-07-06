using System;
using System.Threading.Tasks;
using HoldTheMoney.Domain.Entities;
using HoldTheMoney.Domain.Interfaces.Services;

namespace HoldTheMoney.Service
{
    public class UserService : IUserService
    {
        public User Create(User user)
        {
            user.Id = Guid.NewGuid();
            return user;
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
