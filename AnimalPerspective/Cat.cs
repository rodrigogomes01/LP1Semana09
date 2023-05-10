using System;

namespace AnimalPerspective
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples { get {return 6;} }
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}
