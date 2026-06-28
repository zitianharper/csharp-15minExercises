using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises15Mins
{
    public class PasswordValidator60Mins
    {
        public bool PassWordValidatorMethod(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input == "")
                return false;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (input.Length < 8)
                return false;

            if (!input.Any(c => char.IsUpper(c)))
                return false;

            if (!input.Any(c => char.IsLower(c)))
                return false;

            if (!input.Any(c => char.IsDigit(c)))
                return false;

            return true;
        }
    }
}
