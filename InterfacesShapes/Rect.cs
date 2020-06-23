using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesShapes {
    public class Rect : IShape {

        public int Leg1 { get; set; } 
        public int Leg2 { get; set; }

        public Rect(int l1, int l2) { 
            Leg1 = l1;
            Leg2 = l2;
        }

        public void FindPerimeter() {
            Console.WriteLine($"Perimeter is {Leg1 + Leg2 + Leg1 + Leg2}");

        }


    }
}
