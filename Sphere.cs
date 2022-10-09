using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeClasses
{
    internal class Sphere
    {
        public double radius;
        const double pi = 3.1415926535897931;

        public double getVol()
        {
            return Math.Pow(radius, 3) * (4.0f / 3.0f) * pi;
        }
    }
}
