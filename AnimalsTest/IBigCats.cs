using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsTest
{
    public interface IBigCats
    {
       bool IsValidName(string name);
        /// <summary>
        /// returns animal voice
        /// </summary>
        /// <returns></returns>
        string Voice();
        /// <summary>
        /// returns distance which animal will be able to run for a certain time
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        int Distance(int hours);
    }
}
