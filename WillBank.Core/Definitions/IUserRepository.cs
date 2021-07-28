using WillBank.Model;

namespace WillBank.Core
{
    public interface IUserRepository
    {
        bool RegisterCustomer(User customer, UserProfile userProfile, string password);

        bool RegisterAdmin(User admin, UserProfile userProfile, string password);

        bool RegisterProfile(UserProfile userProfile);
    }
}