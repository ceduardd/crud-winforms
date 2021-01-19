using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Controllers.Helpers
{
    public class Validator
    {
        private static Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public static bool IsValidEmail(string email) => emailRegex.IsMatch(email);

        public static bool IsValidCedula(string cedula) => cedula.Length < 10 ? false : true;

        public static bool AnyFieldIsEmpty(string name, string cedula, string email, DateTime birthdate, string category)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(email) || birthdate == null || string.IsNullOrEmpty(category))
            {
                return true;
            }

            return false;
        }
    }
}
