namespace WillBank.Core
{
    public interface IAuthenticationRepository
    {
        bool Login(string email, string password);
    }
}