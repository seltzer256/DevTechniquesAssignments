using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Door
    {
        private bool state = false;
        //TRUE = OPEN ; FALSE = CLOSE

        public bool State { get => state; set => state = value; }

        public void Open()
        {
            if (state == true)
            {
                Console.WriteLine("The Door is already open");
            }
            else
            {
                state = true;
            }
        }
        public void Close()
        {
            if (state == false)
            {
                Console.WriteLine("The Door is already close");
            }
            else
            {
                state = false;
            }
        }
    }
}
