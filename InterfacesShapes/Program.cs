using System;

namespace InterfacesShapes {
    class Program {
        static void Main(string[] args) {

            var quad1 = new Quad(2, 4, 6, 8);
            quad1.FindPerimeter();

            var rect1 = new Rect(2, 4);
            quad1.FindPerimeter();

            var sq1 = new Square(2);
            quad1.FindPerimeter();


            IShape[] shapes = new IShape[10]; //calls an array of type IShape called shapes
            shapes[0] = quad1;
            shapes[1] = rect1;
            shapes[2] = sq1;

            foreach (var shape in shapes) {
                if (shape == null) continue;
                shape.FindPerimeter();
            }
        }
    }
}
