﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public  class Circle: Shape
    {
        int r;
        public Circle(int radius)
        {
             r = radius;
        }
        public override int Area()
        {
            return 3 * r * r;
        }
    }
}
