using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Button
    {
        private string[] type = {"O","C","U","D","A",""};
        private bool state=false;

        public bool State { get => state; set => state = value; }
        public string[] Type { get => type; set => type = value; }

        public void Press(Door Door, int Value)
        {
            if (state == false)
            {
                state = true;
                switch (type[Value])
                {
                    case "O":
                        Door.Open();
                        break;
                    case "C":
                        Door.Close();
                        break;
                    default:
                        Console.WriteLine("Operation Error...");
                        break;
                }
            }
            else
            {
                state = false;
            }
        }
        public void ElevatorOptions(MotorSystem motor)
        {
            if (state == false)
            {
                state = true;
                switch (type)
                {
                    case "U":

                        break;
                    case "D":

                        break;
                    case "A":

                        break;
                    default:
                        Console.WriteLine("Operation Error...");
                        break;
                }
            }
            else
            {
                state = false;
            }
        }

    }
}
