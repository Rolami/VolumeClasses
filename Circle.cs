﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeClasses
{
    internal class Circle
    {
        public double radius;
        const double pi = 3.1415926535897931;

        //public Circle(double radius)
        //{

        //}

        public double getArea()
        {
            return Math.Pow(radius, 2) * pi;
        }


    }

}
