using System;

namespace Peregruzka

{

    public class Decart

    {

        int x { get; set; }

        int y { get; set; }

        int z { get; set; }

        int t { get; set; }

        // конструктор

        public Decart(int x, int y, int z, int t)

        {

            this.x = x;

            this.y = y;

            this.z = z;

            this.t = t;
        }

        // квадрат расстояния для 4d-точки

        public int distance(int a, int b, int c, int e)

        {
            return a * a + b * b + c * c + e * e;
        }

        // квадрат расстояния для 3d-точки

        public int distance(int a, int b, int c)

        {

            return a * a + b * b + c * c;

        }

        // квадрат расстояния для 2d-точки

        public int distance(int a, int b)

        {

            return a * a + b * b;

        }

        // квадрат расстояния для 1d-точки

        public int distance(int a)

        {

            return a * a;

        }

        // квадрат расстояния для 4d-объекта

        public int distance()

        {

            return x * x + y * y + z * z + t * t;

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Decart d = new Decart(4, 4, 4, 4);

            Console.WriteLine(d.distance());

            Console.WriteLine(d.distance(3));

            Console.WriteLine(d.distance(3, 4));

            Console.WriteLine(d.distance(3, 4, 5));

            Console.WriteLine(d.distance(3, 4, 5, 6));

            Console.ReadKey();

        }

    }

}