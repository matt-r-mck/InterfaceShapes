using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesShapes {
    public class Quad : IShape {

        public int Leg1 { get; set; } 
        public int Leg2 { get; set; }
        public int Leg3 { get; set; }
        public int Leg4 { get; set; }


        public void FindPerimeter() {
            Console.WriteLine($"Perimeter is {Leg1 + Leg2 + Leg3 + Leg4}");

        }
        public Quad(int l1, int l2, int l3, int l4) {
            Leg1 = l1;
            Leg2 = l2;
            Leg3 = l3;
            Leg4 = l4;
        }
    }
}
