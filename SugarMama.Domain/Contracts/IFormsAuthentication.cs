using System;
using System.Collections.Generic;

namespace SugarMama.Domain.Contracts
{
    public interface IFormsAuthentication
    {
        void SignIn(string username, bool createPersistentCookie, IEnumerable<string> roles);
        void SignOut();
    }
}
