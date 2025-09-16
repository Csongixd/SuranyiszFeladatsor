namespace SuranyiszFeladatsor
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello, World!");
        }
        static void F2()
        {
            Console.Write("Név: ");
            string h = Console.ReadLine();
            Console.WriteLine($"Szia {h}!");
        }
        static void F3()
        {
            Console.Write("Szám: ");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine(g*2);
        }
        static void F4()
        {
            Console.Write("Egyik szám: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Másik szám: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"a) Összeg: {x+y}");
            Console.WriteLine($"b) Különbség: {x-y}");
            Console.WriteLine($"c) Szorzat: {x*y}");
            if (y == 0) Console.WriteLine("d) A számoknak nincs hányadosa.");
            else Console.WriteLine($"d) Hányados: {(float)x / (float)y}");
        }
        static void F5()
        {
            Console.Write("Egyik szám: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Másik szám: ");
            int y = int.Parse(Console.ReadLine());
            string h = "Nagyobbik: ";
            if (x > y) h += x;
            else h += y;
            Console.WriteLine(h);
        }
        static void F6()
        {
            Console.Write("Egyik szám: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Másik szám: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Harmadik szám: ");
            int z = int.Parse(Console.ReadLine());
            int[] global = [x, y, z];
            Array.Sort(global);
            Console.WriteLine($"Legkisebbik: {global[0]}");
        }
        static void F7()
        {
            Console.Write("a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int z = int.Parse(Console.ReadLine());
            if (x + y > z && y + z > x && x + z > y) Console.WriteLine("Az oldalakból szerkeszthető háromszög.");
            else Console.WriteLine("Az oldalakból nem szerkeszthető háromszög.");
        }
        static void F8()
        {
            Console.Write("Egyik szám: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Másik szám: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"A két szám számtani közepe: {(x+y)/2}");
            Console.WriteLine($"A két szám mértani közepe: {Math.Sqrt(x*y)}");
        }
        static void F9()
        {
            Console.Write("a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int z = int.Parse(Console.ReadLine());
            int d = (y * y) - (4 * x * z);
            if (d < 0) Console.WriteLine("Az egyenletnek nincs megoldása.");
            else Console.WriteLine("Az egyenletnek van megoldása.");
        }
        static void F10()
        {
            Console.Write("a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int z = int.Parse(Console.ReadLine());
            int d = (y * y) - (4 * x * z);
            if (d < 0) Console.WriteLine("Az egyenletnek nincs megoldása.");
            else if (d == 0)
            {
                int x0 = (-y) / (2 * x);
                Console.WriteLine($"x1 = x2 = {x0}");
            } else
            {
                float x1 = ((float)(-y) + (float)Math.Sqrt(d)) / (float)(2 * x);
                float x2 = ((float)(-y) - (float)Math.Sqrt(d)) / (float)(2 * x);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
        }
        static void F11()
        {
            Console.Write("a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y = int.Parse(Console.ReadLine());
            double z = Math.Atan((double)x/y);
            Console.WriteLine("c = "+Math.Round(Math.Sqrt((x*x) + (y*y)), 2));
        }
        static void F12()
        {
            Console.Write("a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"Felszín: {(2*x*y) + (2*x*z) + (2*y*z)}");
            Console.WriteLine($"Térfogat: {x*y*z}");
        }
        static void F13()
        {
            Console.Write("Átmérő: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Kerület: {(float)(2*r*Math.PI)}\nTerület: {(float)(r*r*Math.PI)}");
        }
        static void F14()
        {
            Console.Write("Sugár: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Középponti szög: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Határoló ív területe: {(double)(r*r*Math.PI*(a/360.0))}");
            Console.WriteLine($"Határoló ív hossza: {(double)((r*Math.PI*a)/180)}");
        }
        static void Main()
        {
            F1();
            F2();
            F3();
            F4();
            F5();
            F6();
            F7();
            F8();
            F9();
            F10();
            F11();
            F12();
            F13();
            F14();
        }
    }
}
