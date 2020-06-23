using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesShapes {
    public class Square : IShape {

        public int Leg1 { get; set; }


        public Square(int l1) {
            Leg1 = l1;
        }

        public void FindPerimeter() {
            Console.WriteLine($"Perimeter is {Leg1  * 4}");

        }

    }
}
