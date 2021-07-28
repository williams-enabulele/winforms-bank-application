using System.Text.RegularExpressions;

namespace Shared
{
    public static class Validations
    {
        public static bool IsValidEmail(string email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
             @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
                return (true);
            else

                return (false);
        }

        public static bool IsValidText(string Name)
        {
            bool nullTest = string.IsNullOrWhiteSpace(Name);
            var nameRegex = new Regex(@"^[a-zA-Z]+$");
            bool isValidated = nameRegex.IsMatch(Name);
            if (isValidated == true && nullTest == false)
            {
                return true;
            }
            else return false;
        }

        public static bool IsValidPassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum6Chars = new Regex(@".{6,}");

            bool isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum6Chars.IsMatch(password);
            if (isValidated == true)
            {
                return true;
            }
            else return false;
        }

        public static bool ConfirmPassword(string password, string password2)
        {
            bool check = password == password2 ? true : false;
            return check;
        }
    }
}