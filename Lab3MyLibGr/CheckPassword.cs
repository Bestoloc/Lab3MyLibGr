using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3MyLibGr
{
    public class CheckPassword
    {
        public static bool IsNumeric(string word)
        {
            if (word.Length == 0)
                return false;
            foreach (char c in word)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public static bool IsLower(string word)
        {
            if (word.Length == 0)
                return false;
            foreach (char c in word)
            {
                if (char.IsDigit(c))
                    continue;
                if (!char.IsLower(c))
                    return false;
            }
            return true;
        }
        public static bool IsUpper(string word)
        {
            if (word.Length == 0)
                return false;
            foreach (char c in word)
            {
                if (char.IsDigit(c))
                    continue;
                if (!char.IsUpper(c))
                    return false;
            }
            return true;
        }
        public static bool HasDigit(string word)
        {
           
            
            foreach (char c in word)
            {
                if (char.IsDigit(c))
                    return true;
                
            }
            return false;
        }

        public static int PasswordLevel(string password)
        {
            if (password.Length < 6)
                return 0;
            if (IsNumeric(password))
                return 1;
            if (!HasDigit(password) && IsLower(password))
                return 1;
            if (!HasDigit(password) && IsUpper(password))
                return 1;
            if ((password.ToLower() != password) && (password.ToUpper() != password) && !HasDigit(password))
                return 2;
            if (HasDigit(password) && IsLower(password))
                    return 2;
            if (HasDigit(password) && IsUpper(password))
                    return 2;
            return 3;
        }
    }
}
