using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal
    {
        public int NumberOfNipples { get {return 6;} }
    }
}