using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    class Rec: Shape
    {
        public Rec(int width, int height ) : base(width, height)
        {
            Console.WriteLine("Omkrets");
            int a = width + height * 2;
            Console.WriteLine(a);
            Console.WriteLine("Area");
            int b = width * height;
            Console.WriteLine(b);
        }
    }
