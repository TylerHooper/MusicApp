using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BLL
{
    public class Main
    {
        public static int RndGenerator(int min, int max)
        {
            // Create a new random number 1-10, return
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
