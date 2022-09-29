using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARVingarna;


    class Tri : IShape
    {
        private float width;
        private float height;
        public Tri(float width, float height)
        {
            
        }
        public float Circumference()
        {
            return ((float)Math.Sqrt(width * width + height * height) + width + height); 
        }
        
        
        public float Area()
        {
            return width * height / 2;
        }
    }


    
