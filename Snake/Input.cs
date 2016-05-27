using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        //Loading the list of available Keyboard buttons
        private static Hashtable keyTable = new Hashtable();

        //Performing a check to see if button is pressed.
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }

        //if a keyboard button is pressed
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
