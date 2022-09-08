using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    class Tri : Shape
    {
        public Tri(int width, int height) : base(width, height)
        {
            
        }
        public void omkrets()
        {
            int c = width * width + height * height;
            omkrets = ((int)Math.Sqrt(c) + width + height); 
        }
        public void area()
        {
            int d = width * height / 2;
        }
    }


    
