namespace Shared
{
    public interface ICryptography
    {
        string CreateSalt(int size);

        string GenerateHash(string input, string salt);

        bool AreEqual(string plainTextInput, string hashedInput, string salt);
    }
}