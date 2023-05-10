using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples { get {return 2;} }
        public int NumberOfWings { get {return 2;} }
    }
}