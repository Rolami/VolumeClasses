using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeClasses
{
    internal class Triangle
    {
        public double height;
        public double _base;

        public double getTriArea()
        {

            return (1.0f / 2.0f) * _base * height;
        }
    }
}
