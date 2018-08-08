using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Cage
    {
        private double MaximunWeight;
        private int MaximunPeople;
        private Button[] floorButtons = new Button[23];

        public double MaximunWeight1 { get => MaximunWeight; set => MaximunWeight = value; }
        public int MaximunPeople1 { get => MaximunPeople; set => MaximunPeople = value; }
        internal Button[] FloorButtons { get => floorButtons; set => floorButtons = value; }


    }
}
