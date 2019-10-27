using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BLL
{
    public class KeySigGenerator
    {
        // init keyboard array
        public static string[] keyBoard = { "C", "D♭", "D", "E♭", "E", "F", "G♭", "G", "A♭", "A", "B♭", "B" };

        // W = Whole Step, H = Half Step, E = Whole + Half Step
        public static char[] majorMode = { 'W', 'W', 'H', 'W', 'W', 'W', 'H' };
        public static char[] natMinorMode = { 'W', 'H', 'W', 'W', 'H', 'W', 'W' };
        public static char[] harMinorMode = { 'W', 'H', 'W', 'W', 'H', 'E', 'H' };
        public static char[] melMinorMode = { 'W', 'H', 'W', 'W', 'W', 'W', 'H' };
        public static char[] dorianMode = { 'W', 'H', 'W', 'W', 'W', 'H', 'W' };
        public static char[] phrygianMode = { 'H', 'W', 'W', 'W', 'H', 'W', 'W' };
        public static char[] lydianMode = { 'W', 'W', 'W', 'H', 'W', 'W', 'H' };
        public static char[] mixolydianMode = { 'W', 'W', 'H', 'W', 'W', 'H', 'H' };
        public static char[] locrianMode = { 'H', 'W', 'W', 'H', 'W', 'W', 'W' };
        public static char[] otherMode = new char[6];

        // determines the mode, and calls Stepper method to step through the keys accordingly
        public static string[] ModeResponse(char key, string accidential, string mode, string customMode)
        {
            string[] result = new string[8];

            // check for the mode and use input passed in from the form for the stepper method
            switch (mode)
            {
                case "major":
                    result = Stepper(key, accidential, majorMode);
                    break;
                case "natMinor":
                    result = Stepper(key, accidential, natMinorMode);
                    break;
                case "harMinor":
                    result = Stepper(key, accidential, harMinorMode);
                    break;
                case "melMinor":
                    result = Stepper(key, accidential, melMinorMode);
                    break;
                case "dorian":
                    result = Stepper(key, accidential, dorianMode);
                    break;
                case "phrygian":
                    result = Stepper(key, accidential, phrygianMode);
                    break;
                case "lydian":
                    result = Stepper(key, accidential, lydianMode);
                    break;
                case "mixolydian":
                    result = Stepper(key, accidential, mixolydianMode);
                    break;
                case "locrian":
                    result = Stepper(key, accidential, locrianMode);
                    break;
                case "other":
                    result = Stepper(key, accidential, otherMode);
                    break;
                default:
                    result[0] = "Uh oh, something went wrong!";
                    break;
            }

            //return String.Format("The keys are: {0} {1} {2} {3} {4} {5} {6} {7}", result[0], result[1], result[2], result[3], result[4], result[5], result[6], result[7]);
            return result;
        }

        // method to step through the keys
        public static string[] Stepper(char key, string accidential, char[] input)
        {
            string[] result = new string[8];
            int keyNum = 0;
            int iterator = 0;

            // init the first key
            switch (key)
            {
                case 'C':
                    keyNum = 0;
                    break;
                case 'D':
                    keyNum = 2;
                    break;
                case 'E':
                    keyNum = 4;
                    break;
                case 'F':
                    keyNum = 5;
                    break;
                case 'G':
                    keyNum = 7;
                    break;
                case 'A':
                    keyNum = 9;
                    break;
                case 'B':
                    keyNum = 10;
                    break;
                default:
                    keyNum = -1;
                    break;
            }

            // add or subtracked based on accidential
            if (accidential == "flat") keyNum--;
            if (accidential == "sharp") keyNum++;

            // did we go down to B or up to C?
            if (keyNum == -1) keyNum = 10;
            if (keyNum == 11) keyNum = 0;

            // setting first entry in the result
            result[0] = keyBoard[keyNum];
            iterator = keyNum;

            for (int i = 0; i <= 6; i++)
            {
                int step = 0;

                // determine type of step based on input
                switch (input[i])
                {
                    case 'H':
                        step = 1;
                        break;
                    case 'W':
                        step = 2;
                        break;
                    case 'E':
                        step = 3;
                        break;
                    default:
                        break;
                }

                // next step on the keyboard
                iterator += step;

                // checking for the end of the keyboard, move back to the beginning if so
                if (iterator > 11)
                {
                    iterator -= 12;
                    result[i+1] = keyBoard[iterator];

                }
                else
                {
                    result[i+1] = keyBoard[iterator];
                }
            }

            return result;
        }
    }
}
