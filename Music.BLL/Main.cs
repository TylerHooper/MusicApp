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

    public class KeySignatureForm
    {
        // gets or sets the key
        public char Key { get; set; }

        // gets or sets the accidential
        public string Accidential { get; set; }

        // gets or sets the mode
        public string Mode { get; set; }

        // gets or sets the custom mode, if used
        public string CustomMode { get; set; }
    }
}
