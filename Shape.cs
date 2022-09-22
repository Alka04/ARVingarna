using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    class Shape
    {
        protected int width;
        protected int height;
        
        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual int Circumference()
        {
            return 0;
        }

        public virtual int Area()
        {
            return 0;
        }
    }