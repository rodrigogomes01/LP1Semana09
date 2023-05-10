using System;

namespace AnimalPerspective
{
    public class Program
    {
        private static void Main()
        {
            const int n = 10;
            Animal[] animals = new Animal[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                animals[i] = rnd.Next(4) switch
                {
                    0 => new Bat(),
                    1 => new Bee(),
                    2 => new Cat(),
                    3 => new Dog(),
                    _ => throw new ArgumentOutOfRangeException("Unknown animal!")
                };
            }

            foreach (Animal a in animals)
            {
                Console.Write($"{a.GetType().Name} says ");
                Console.Write(a.Sound());
                if (a is IMammal)
                    Console.Write(
                        $", No.Nipples = {(a as IMammal).NumberOfNipples}");
                if (a is ICanFly)
                    Console.Write(
                        $", No.Wings = {(a as ICanFly).NumberOfWings}");
                Console.WriteLine();
            }

            // Possible output:

            // Dog says Sound will be Woof!, No.Nipples = 8
            // Dog says Sound will be Woof!, No.Nipples = 8
            // Bat says Sound will be <Click>, No.Nipples = 2, No.Wings = 2
            // Dog says Sound will be Woof!, No.Nipples = 8
            // Cat says Sound will be Miau, No.Nipples = 6
            // Cat says Sound will be Miau, No.Nipples = 6
            // Cat says Sound will be Miau, No.Nipples = 6
            // Cat says Sound will be Miau, No.Nipples = 6
            // Cat says Sound will be Miau, No.Nipples = 6
            // Dog says Sound will be Woof!, No.Nipples = 8

        }
    }
}
