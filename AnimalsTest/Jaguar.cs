using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimalsTest
{
    public class Jaguar : IBigCats
    {
        public bool IsValidName(string? name)
        {
            Regex expression = new Regex(@"^[a-zA-Z]+$");
            if (!String.IsNullOrEmpty(name))
            {
                return expression.IsMatch(name);
            }
            return false;

        }
        public int Distance(int hours) => hours * 90;

        public string Voice() => "I am jaguar.Dangerous kitty";


    }
}
