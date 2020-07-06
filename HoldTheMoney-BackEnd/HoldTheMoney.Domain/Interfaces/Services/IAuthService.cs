using System;
using HoldTheMoney.Domain.Entities;
using HoldTheMoney.Domain.ValueObjects;

namespace HoldTheMoney.Domain.Interfaces.Services
{
    public interface IAuthService
    {
        User Authenticate(AuthInfo authInfo);
    }
}
