using SugarMama.Model;
using System;

namespace JotAThought.Domain.Contracts
{
    public interface IUserService
    {
        bool ChangePassword(int id, string password);
        User GetUser(string login, string password);
        bool CreateUser(string userName, string password, string email, out string confirmationToken);
        bool VerifyUser(string token, out string userName);
    }
}