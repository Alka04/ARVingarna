using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARVingarna;


    class Rec : IShape
    {
        private float width;
        private float height;
        public Rec(float width, float height )
        {
            
        }
        public float Circumference()
            {
                return width * 2 + height * 2;
            }
        public float Area()
            {
                return width * height;
            }
    }

