using System;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples { get {return 8;} }
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
