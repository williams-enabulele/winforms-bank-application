using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WillBank.Core
{
    public interface IAuthenticationRepository
    {
     Task<bool> LoginAsync(string email, string password);

    }
}
