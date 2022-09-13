using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    class Rec: Shape
    {
        public Rec(int width, int height ) : base(width, height)
        {
            
        }
        public int RO()
        {
            return width * 2 + height * 2;
        }
        public int RA()
        {
            return width * height;
        }
    }
