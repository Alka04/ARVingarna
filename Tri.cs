using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    class Tri : Shape
    {
        public Tri(int width, int height) : base(width, height)
        {
            
        }
        public override int Circumference()
        {
            return ((int)Math.Sqrt(width * width + height * height) + width + height); 
        }
        
        
        public override int Area()
        {
            return width * height / 2;
        }
    }


    
