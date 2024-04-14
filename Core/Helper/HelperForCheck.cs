using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper
{
    public static class HelperForCheck
    {
        public static bool IsValidName(this string name)
        {
            return name.Length >= 3 && name == name.ToUpper();
        }

        public static bool IsValidSurname(this string surname)
        {
            return surname.Length >= 3 && surname == surname.ToUpper();
        }

        public static bool IsValidClassName(this string className)
        {
            return className.Length == 5 && Char.IsUpper(className[0]) && Char.IsUpper(className[1]) && Char.IsDigit(className[2]) && Char.IsDigit(className[3]) && Char.IsDigit(className[4]);
        }
    }
}
