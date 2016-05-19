using System;

namespace PasswordKata
{
    public class PasswordVerifier
    {
        private readonly string _password;

        public PasswordVerifier(string password)
        {
            _password = password;
        }

        string Message;
        public bool Verify()
        {
            bool verify = false;
            try
            {
                if (_password != null && _password != "")
                {
                    if (_password.Trim().Length != 8)
                    {
                        throw new Exception("password should be larger than 8 chars");
                    }
                    else if (!System.Text.RegularExpressions.Regex.IsMatch(_password.Trim(), "(?=.*[A-Z])"))
                    {
                        throw new Exception("password should have one uppercase letter at least");
                    }
                    else if (!System.Text.RegularExpressions.Regex.IsMatch(_password.Trim(), "(?=.*[a-z])"))
                    {
                        throw new Exception("password should have one lowercase letter at least");
                    }
                    else if (!System.Text.RegularExpressions.Regex.IsMatch(_password.Trim(), "(?=.*\\d)"))
                    {
                        throw new Exception("password should have one number at least");
                    }
                }
                else
                {
                    Message = "password should not be null";
                }
            }
            catch (Exception e)
            {

            }
            return verify;
        }
    }
}