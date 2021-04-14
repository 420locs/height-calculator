using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidateDataLibrary {
    public static class Validator {
        public static bool IsEmpty(string txt) {
            return txt.Trim().Length == 0;
        }
        public static bool IsNumberic(string txt) {
            return Regex.IsMatch(txt.Trim(), @"^[0-9]+$");
        }
    }
}
