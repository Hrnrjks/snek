using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snek
{
    class Input
    {
        // load available keyboard keys
        private static Hashtable keyTable = new Hashtable();

        // check whether a specific 'key' is pressed
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        // if the 'key''s state is changed then update the state in the keyTable
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
