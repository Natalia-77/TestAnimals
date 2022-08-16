using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimalsTest{
    
    public class Lion : IBigCats
    {

        private string? _name;
        public string? Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!IsValidName(value))
                {

                    _name = "Baoka";
                }
                else
                {
                    _name = value;
                }

            }
        } 

        public bool IsValidName(string? name)
        {
            Regex expression = new Regex(@"^[a-zA-Z]+$");
            if (!string.IsNullOrEmpty(name))
            {
                return expression.IsMatch(name);
            }
            return false;

        }
        public int Distance(int hours) => hours * 80;

        public string Voice() => "I am a lion - king of jungle";
        
    }
}
