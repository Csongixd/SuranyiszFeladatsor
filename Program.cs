using System.Drawing;
using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
            int g = InputNumber("Szám: ");
            Console.WriteLine(g*2);
        }
        static void F4()
        {
            int x = InputNumber("Egyik szám: ");
            int y = InputNumber("Másik szám: ");
            Console.WriteLine($"a) Összeg: {x+y}");
            Console.WriteLine($"b) Különbség: {x-y}");
            Console.WriteLine($"c) Szorzat: {x*y}");
            if (y == 0) Console.WriteLine("d) A számoknak nincs hányadosa.");
            else Console.WriteLine($"d) Hányados: {(float)x / (float)y}");
        }
        static void F5()
        {
            int x = InputNumber("Egyik szám: ");
            int y = InputNumber("Másik szám: ");
            string h = "Nagyobbik: ";
            if (x > y) h += x;
            else h += y;
            Console.WriteLine(h);
        }
        static void F6()
        {
            int x = InputNumber("Egyik szám: ");
            int y = InputNumber("Másik szám: ");
            int z = InputNumber("Harmadik szám: ");
            int[] global = [x, y, z];
            Array.Sort(global);
            Console.WriteLine($"Legkisebbik: {global[0]}");
        }
        static void F7()
        {
            int x = InputNumber("a = ");
            int y = InputNumber("b = ");
            int z = InputNumber("c = ");
            if (x + y > z && y + z > x && x + z > y) Console.WriteLine("Az oldalakból szerkeszthető háromszög.");
            else Console.WriteLine("Az oldalakból nem szerkeszthető háromszög.");
        }
        static void F8()
        {
            int x = InputNumber("Egyik szám: ");
            int y = InputNumber("Másik szám: ");
            Console.WriteLine($"A két szám számtani közepe: {(x+y)/2}");
            Console.WriteLine($"A két szám mértani közepe: {Math.Sqrt(x*y)}");
        }
        static void F9()
        {
            int x = InputNumber("a = ");
            int y = InputNumber("b = ");
            int z = InputNumber("c = ");
            int d = (y * y) - (4 * x * z);
            if (d < 0) Console.WriteLine("Az egyenletnek nincs megoldása.");
            else Console.WriteLine("Az egyenletnek van megoldása.");
        }
        static void F10()
        {
            int x = InputNumber("a = ");
            int y = InputNumber("b = ");
            int z = InputNumber("c = ");
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
            int x = InputNumber("a = ");
            int y = InputNumber("b = ");
            Console.WriteLine("c = "+Math.Round(Math.Sqrt((x*x) + (y*y)), 2));
        }
        static void F12()
        {
            int x = InputNumber("a = ");
            int y = InputNumber("b = ");
            int z = InputNumber("c = ");
            Console.WriteLine($"Felszín: {(2*x*y) + (2*x*z) + (2*y*z)}");
            Console.WriteLine($"Térfogat: {x*y*z}");
        }
        static void F13()
        {
            int r = InputNumber("Sugár: ");
            Console.WriteLine($"Kerület: {(float)(2*r*Math.PI)}\nTerület: {(float)(r*r*Math.PI)}");
        }
        static void F14()
        {
            int r = InputNumber("Sugár: ");
            int a = InputNumber("Középponti szög: ");
            Console.WriteLine($"Határoló ív területe: {(double)(r*r*Math.PI*(a/360.0))}");
            Console.WriteLine($"Határoló ív hossza: {(double)((r*Math.PI*a)/180)}");
        }
        static void F15()
        {
            int z = InputNumber("Adj meg egy pozitív egész számot: ");
            if (z <= 0)
            {
                Console.WriteLine("Érvénytelen szám, véletlenszerű érték használata");
                z = new Random().Next(1, 100);
            }
            for (int i = 0; i <= z; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void F16()
        {
            int z = InputNumber("Adj meg egy pozitív egész számot: ");
            if (z <= 0)
            {
                Console.WriteLine("Érvénytelen szám, véletlenszerű érték használata");
                z = new Random().Next(1, 100);
            }
            for (int i = 0; i <= z; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void F17()
        {
            int main = InputNumber("A szám, aminek kellenek az osztói: ");
            Console.Write($"{main} osztói: ");
            for (int c = 1; c <= main; c++) if (main % c == 0) Console.Write($"{c}, ");
            Console.WriteLine();
        }
        static void F18()
        {
            int main = InputNumber("A szám, aminek kellenek az osztóinak összege: ");
            Console.Write($"{main} osztóinak összege: ");
            int sum = 0;
            for (int c = 1; c <= main; c++) if (main % c == 0) sum += c;
            Console.Write(sum);
            Console.WriteLine();
        }
        static void F19()
        {
            int p = InputNumber("Tökéletes szám jelölt: ");
            int sum = 0;
            for (int c = 1; c <= p; c++) if (p % c == 0) sum += c;
            Console.WriteLine(p == (sum/2) ? "A szám tökéletes szám." : "A szám nem tökéletes szám.");
        }
        static void F20()
        {
            int b_se = InputNumber("Alap: ");
            int power = InputNumber("Kitevő: ");
            float result = 1;
            if (power >= 0) for (int z = 0; z < power; z++) result *= b_se;
            else for (int z = power; z < 0; z++) result /= b_se;
            Console.WriteLine($"{b_se}^{power} = {result}");
        }
        static void F21() 
        {
            int z = 0;
            while (z <= 0)
            {
                z = InputNumber("Adj meg egy pozitív számot: ");
            }
            Console.WriteLine(z);
        }
        static void F22()
        {
            List<int> e = new List<int>();
            int z;
            do
            {
                z = InputNumber("Adj meg egy tíznél kisebb számot (befejezéshez írj tizet vagy nagyobb számot): ");
                if (z < 10) e.Add(z);
            } while (z < 10);
            z = 0;
            foreach (int x in e) z += x;
            Console.WriteLine($"A számok összege: {z}");
        }
        static void F23()
        {
            int u = InputNumber("Adj meg egy számot a 2-esekre való felosztáshoz: ");
            Console.Write(u);
            string output = "";
            while (u % 2 == 0)
            {
                u /= 2;
                output += "2*";
            }
            Console.Write($" = {output}{u}");
            Console.WriteLine();
        }
        static void F24()
        {
            string fonal;
            do
            {
                Console.WriteLine("Írd be, hogy 'alma'!");
                fonal = Console.ReadLine();
            } while (fonal != "alma");
            Console.WriteLine("Az alma gyümölcs!");
        }
        static void F25()
        {
            int x = InputNumber("3-asokra való feldarabolandó szám: ");
            Console.Write(x);
            int y = 0;
            while (x >= 3)
            {
                x -= 3;
                y++;
            }
            Console.Write($" = {y}*3+{x}");
            Console.WriteLine();
        }
        static void F26()
        {
            int p = InputNumber("Prímszám jelölt: ");
            int sum = 0;
            for (int c = 1; c <= p; c++) if (p % c == 0) sum += c;
            Console.WriteLine(p == (sum - 1) ? "A szám prímszám." : "A szám nem prímszám.");
        }
        static void F27()
        {
            int p = InputNumber("Prímszámok eddig a számig: ");
            Console.Write($"Prímszámok {p}-ig: ");
            for (int c = 1; c <= p; c++)
            {
                int sum = 0;
                for (int x = 1; x <= c; x++) if (c % x == 0) sum += x;
                if (c == (sum - 1)) Console.Write($"{c}, ");
            }
            Console.WriteLine();
        }

        static void F28()
        {
            int j = InputNumber("Prímtényezők lekérése erről a számról: ");
            List<int> primek = new List<int>();
            for (int zz = 0; zz < j; zz++)
            {
                int sum = 0;
                for (int x = 1; x <= zz; x++) if (zz % x == 0) sum += x;
                if (zz == (sum - 1) && j % zz == 0) primek.Add(zz);
            }
            Console.WriteLine($"{j} prímosztói: {string.Join(", ", primek)}");
        }
        static void F29()
        {
            int main = InputNumber("Felosztandó szám: ");
            Console.Write(main);
            List<int> primek = new List<int>();
            for (int zz = 0; zz < main; zz++)
            {
                int sum = 0;
                for (int x = 1; x <= zz; x++) if (zz % x == 0) sum += x;
                if (zz == (sum - 1) && main % zz == 0) primek.Add(zz);
            }
            string output = " = ";
            while (main > 2)
            {
                for (int index = 0; index < primek.Count; index++)
                {
                    while (main % primek[index] == 0)
                    {
                        main /= primek[index];
                        output += $"{primek[index]}*";
                    }
                }
            }
            if (main > 1) output += main;
            else output = output.Substring(0, output.Length-1);
            Console.Write(output);
            Console.WriteLine();
        }
        static void F30()
        {
            int x = InputNumber("LNKO(1): ");
            int y = InputNumber("LNKO(2): ");
            while (y > 0)
            {
                int z = y;
                y = x % y;
                x = z;
            }
            Console.WriteLine($"LNKO: {x}");
        }

        static void F31()
        {
            int x = InputNumber("LKKT(1): ");
            int x0 = x;
            int y = InputNumber("LKKT(2): ");
            int y0 = y;
            while (y > 0)
            {
                int z = y;
                y = x % y;
                x = z;
            }
            Console.WriteLine($"LKKT: {(x0*y0)/x}");
        }
        static void F32()
        {
            int b_se = InputNumber("Add meg a szorzótábla alapját: ");
            for (int r = 1; r <= 10; r++) Console.WriteLine($"{r} * {b_se} = {r * b_se}");
        }
        static void F33()
        {
            int b_se = InputNumber("Add meg az összegtábla alapját: ");
            for (int r = 1; r <= 10; r++) Console.WriteLine($"{r} + {b_se} = {r + b_se}");
        }
        static void F34()
        {
            Console.Write("Párosával speciális számok: ");
            List<string> parok = [];
            for (int x = 10; x <= 99; x++)
            {
                for (int y = 10; y <= 99; y++)
                {
                    int x1 = x / 10;
                    int x2 = x % 10;
                    int y1 = y / 10;
                    int y2 = y % 10;
                    int x_f = (x2 * 10) + x1;
                    int y_f = (y2 * 10) + y1;
                    if (x * y == x_f * y_f) parok.Add($"{x} * {y}");
                }
            }
            Console.Write(string.Join(", ", parok)+"\n");
        }
        static void F35()
        {
            char e = 'a';
            int e_int = Convert.ToInt32(e);
            List<string> charAscii = new();
            while (e_int <= Convert.ToInt32('z'))
            {
                charAscii.Add($"{(char)e_int} {e_int}");
                e_int++;
            }
            e_int = 0;
            string[] printable = new string[charAscii.Count/4];
            bool n = false;
            foreach (string str in charAscii)
            {
                if (!n) printable[e_int] = str;
                else printable[e_int] += $"\t{str}";
                e_int++;
                if (e_int == charAscii.Count / 4)
                {
                    e_int = 0;
                    n = true;
                }
            }
            foreach (string str in printable) Console.WriteLine(str);
        }
        static void F36()
        {
            int width = InputNumber("Add meg a szélességet: ");
            int height = InputNumber("Add meg a hosszúságot: ");
            char[] chars = ['x', 'o'];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(chars[(x+y) % 2]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }
        static void F37()
        {
            int y = InputNumber("Add meg a háromszög magasságát: ");
            string csillag = "*";
            for (int x = 0; x < y; x++)
            {
                Console.WriteLine(csillag);
                csillag += "**";
            }
        }
        static void F38()
        {
            int y = InputNumber("Add meg a háromszög magasságát: ");
            string csillag = "*";
            string space = "";
            for (int z = 0; z < y+1; z++) space += " ";
            for (int x = 0; x < y; x++)
            {
                Console.WriteLine(space+csillag);
                csillag += "**";
                space = space.Substring(0, space.Length-1);
            }
        }
        static void F39()
        {
            int m = InputNumber("Add meg a szélességet: ");
            int n = InputNumber("Add meg a magasságot: ");
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (x == 0 || x == m-1 || y == 0 || y == n-1)
                    {
                        Console.Write('*');
                    } else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write('\n');
            }
        }
        static void F40()
        {
            int maximum = InputNumber("Eddig a számig lesznek a tökéletes számok: ");
            for (int x = 1; x <= maximum; x++)
            {
                int xOsztok = 0;
                for (int y = 1; y < x; y++) if (x % y == 0) xOsztok += y;
                if (x == xOsztok) Console.WriteLine(x);
            }
        }
        static void F41()
        {
            string down = "ABCDEFGHIJKLMNOQPRSTUVWXYZ";
            while (true)
            {
                Console.WriteLine(down);
                char f = down[0];
                if (f == 'Z') return;
                down = down.Substring(1, down.Length-1);
                down = down + f;
            }
        }
        static void F42()
        {
            int length = InputNumber("Add meg a tömb darabszámát: ");
            int x = 0;
            int[] _1 = new int[length];
            while (x < length)
            {
                _1[x] = InputNumber($"Add meg a {x+1}/{length}. számot: ");
                x++;
            }
            x = 0;
            foreach (int eget in _1) if (eget % 2 == 1) x++;
            Console.WriteLine($"Páratlan számok száma: {x}");
        }
        static void F43()
        {
            int length = InputNumber("Add meg a tömb darabszámát: ");
            int x = 0;
            int[] _1 = new int[length];
            while (x < length)
            {
                _1[x] = InputNumber($"Add meg a {x + 1}/{length}. számot: ");
                x++;
            }
            x = 0;
            foreach (int eget in _1) if (eget % 2 == 0) x += eget;
            Console.WriteLine($"Páros számok összege: {x}");
        }
        static void F44()
        {
            int length = InputNumber("Add meg a tömb darabszámát: ");
            int x = 0;
            int[] _1 = new int[length];
            while (x < length)
            {
                _1[x] = InputNumber($"Add meg a {x + 1}/{length}. számot: ");
                x++;
            }
            for (int eget = 0; eget < _1.Length; eget++) if (_1[eget] % 2 == 0)
            {
                Console.WriteLine($"{eget+1}. {_1[eget]}");
            }
        }
        static void F45()
        {
            int length = InputNumber("Add meg a tömb darabszámát: ");
            int[] _1 = new int[length];
            for (int x = 0; x < length; x++) _1[x] = InputNumber($"Add meg a {x + 1}/{length}. számot: ");
            int point = InputNumber("Keresendő szám: ");
            bool e = true;
            int y = 0;
            while (e && y < length)
            {
                if (_1[y] == point)
                {
                    Console.WriteLine($"{point} első indexe: {y}");
                    e = false;
                }
                y++;
            }
            if (e) Console.WriteLine("Nincs ilyen szám a tömbben.");
        }
        static void F46()
        {
            int length = InputNumber("Add meg a tömb darabszámát: ");
            int[] _1 = new int[length];
            for (int x = 0; x < length; x++) _1[x] = InputNumber($"Add meg a {x + 1}/{length}. számot: ");
            int point = InputNumber("Keresendő szám: ");
            int count = 0;
            for (int a = 0; a < length; a++)
            {
                if (_1[a] == point) count++;
            }
            Console.WriteLine($"A szám {count}x szerepel a tömbben.");
        }

        static void F47()
        {
            int length = InputNumber("Add meg a tömb darabszámát: ");
            string[] _1 = new string[length];
            for (int x = 0; x < length; x++) InputString($"Add meg a {x + 1}/{length}. keresztnevet: ");
            string auhhhhhhhhh = InputString("Keresett keresztnév: ");
            int count = 0;
            for (int a = 0; a < length; a++) if (_1[a] == auhhhhhhhhh) count++;
            Console.WriteLine($"A név {count}x szerepel a tömbben.");
        }
        static void F48()
        {
            int length = InputNumber("Add meg a tömb darabszámát: ");
            int[] _1 = new int[length];
            for (int x = 0; x < length; x++) _1[x] = InputNumber($"Add meg a {x + 1}/{length}. számot: ");
            Array.Sort(_1);
            Console.WriteLine($"Legnagyobb ({_1[_1.Length - 1]}) és legkisebb ({_1[0]}) szám különbsége: {(_1[_1.Length - 1] - _1[0])}");
        }
        static void F49()
        {
            int length = InputNumber("Add meg a tömb darabszámát: ");
            int[] _1 = new int[length];
            for (int x = 0; x < length; x++) _1[x] = InputNumber($"Add meg a {x + 1}/{length}. számot: ");
            for (int i = length; i >= 2; i--) {
                for (int j = 0; j < i-1; j++) {
                    if(_1[j] > _1[j + 1]) {
                        int z = _1[j+1];
                        _1[j+1] = _1[j];
                        _1[j] = z;
                    }
                }
            }
            Console.WriteLine($"A számok növekvő sorrendben: {string.Join(", ", _1)}");
        }
        static void F50()
        {
            string h = InputString("Kérem a szót: ");
            Console.WriteLine(string.Join(" ", h.ToCharArray()));
        }
        static void F51()
        {
            string h = InputString("Kérem a szót: ");
            string taboo = InputString("Kérem a tabu betűt: ");
            h = h.Replace(taboo, "");
            Console.WriteLine(h);
        }
        static void F52()
        {
            string h = InputString("Kérem a szót: ");
            for (int i = 1; i < h.Length; i += 2) Console.WriteLine(h[i]);
        }
        static void F53()
        {
            char[] h = InputString("Kérem a szót: ").ToCharArray();
            foreach (char eff in h) Console.WriteLine(Convert.ToInt32(eff));
        }
        static void F54()
        {
            string text = InputString("Kérem a szót: ");
            Console.Write('\n');
            for (int _ = text.Length-1; _ >= 0; _--) Console.Write(text[_]);
            Console.Write('\n');
        }
        static void F55()
        {
            string text = InputString("Kérem a mondatot: ");
            foreach (string altext in text.Split(" ")) Console.WriteLine(altext);
        }
        static void F56()
        {
            string word = InputString("Kérem a szót: ");
            Console.Write("\n");
            for (int bung = word.Length - 1; bung >= 0; bung--) Console.Write(char.ToUpper(word[bung]));
            Console.Write("\n");
        }
        static void F57()
        {
            string text = InputString("Kérem a mondatot: ");
            foreach (string altext in text.Split(" "))
                Console.WriteLine(char.ToUpper(altext[0])+altext.Substring(1, altext.Length-1));
        }
        static void F58()
        {
            string[] f58 = File.ReadAllLines("forras58.be");
            int[] ints = new int[int.Parse(f58[0])];
            for (int z = 1; z < f58.Length; z++) ints[z-1] = int.Parse(f58[z]);
            Array.Sort(ints);
            Console.WriteLine($"Legnagyobb szám: {ints[ints.Length-1]}");
        }
        static void F59()
        {
            string[] f59 = File.ReadAllLines("forras59.be");
            int[] ints = new int[int.Parse(f59[0])];
            for (int z = 1; z < f59.Length; z++) ints[z - 1] = int.Parse(f59[z]);
            Array.Sort(ints);
            int printable = 0;
            bool go = true;
            int x = 0;
            while (go && x < ints.Length)
            {
                if (ints[x] % 2 == 0)
                {
                    printable = ints[x];
                    go = false;
                }
                x++;
            }
            Console.WriteLine($"Legkisebb páros szám: {printable}");
        }
        static void F60()
        {
            string[] f60 = File.ReadAllLines("forras60.be");
            int[] ints = new int[int.Parse(f60[0])];
            for (int z = 1; z < f60.Length; z++) ints[z - 1] = int.Parse(f60[z]);
            Array.Sort(ints);
            int printable = 0;
            int yield = 0;
            foreach (int x in ints)
            {
                if (x % 2 == 1)
                {
                    printable += x;
                    yield++;
                }
            }
            Console.WriteLine($"Páratlan számok átlaga: {printable/yield}");
        }
        static void F61()
        {
            string[] f61 = File.ReadAllLines("forras61.be");
            string[] f61Lengths = new string[f61.Length-1];
            for (int x = 1; x < f61.Length; x++)
            {
                int length0 = f61[x].Length;
                string length = (length0 < 10) ? $"0{length0}" : $"{length0}";
                f61Lengths[x - 1] = $"{length};{f61[x]}";
            }
            Array.Sort(f61Lengths);
            Console.WriteLine($"Leghosszabb szó: {f61Lengths[f61Lengths.Length - 1].Split(";")[1]}");
        }
        static void F62()
        {
            Console.Write("'a' betűvel kezdődő szavak: ");
            string[] data = File.ReadAllLines("forras62.be");
            foreach (string a in data)
            {
                if (a.Substring(0, 1) == "a")
                {
                    Console.Write($"{a}, ");
                }
            }
            Console.WriteLine();
        }
        static void F63()
        {
            string[] f63_0 = File.ReadAllLines("forras63.be");
            int[] f63 = new int[int.Parse(f63_0[0])];
            int[] f63sorted = new int[int.Parse(f63_0[0])];
            for (int x = 1; x < f63_0.Length; x++) f63[x-1] = int.Parse(f63_0[x]);
            for (int x = 0; x < f63.Length; x++)
            {
                for (int y = f63.Length-1; y > 0; y--) if (f63[y] > f63[y - 1])
                    {
                    int z = f63[y-1];
                    f63[y-1] = f63[y];
                    f63[y] = z;
                }
            }
            Console.WriteLine($"A számok csökkenő sorrendben: {string.Join(", ", f63)}");
        }
        static void F64()
        {
            string[] f64 = DataConvert("forras64.be");
            Array.Sort(f64);
            Console.WriteLine($"Szavak ABC-sorrendben: {string.Join(", ", f64)}");
        }
        static void F65()
        {
            int[] f65 = IntList(65);
            for (int x = 0; x < f65.Length; x++)
            {
                for (int y = f65.Length - 1; y > 0; y--) if (f65[y] > f65[y - 1])
                {
                    int z = f65[y - 1];
                    f65[y - 1] = f65[y];
                    f65[y] = z;
                }
            }
            Console.WriteLine($"Legkisebb szám: {f65[f65.Length-1]}");
        }
        static void F66()
        {
            int[] f66 = IntList(66, 2);
            Array.Sort(f66);
            Console.WriteLine($"Legnagyobb páros: {f66[f66.Length-1]}");
        }
        static void F67()
        {
            int[] f67 = IntList(67, 2);
            int x = 0;
            foreach (int y in f67) x += y;
            Console.WriteLine($"Páros számok összege: {x}");
        }
        static void F68()
        {
            string[] f68 = File.ReadAllLines("forras68.be");
            string[] f68Lengths = new string[f68.Length];
            for (int y = 0; y < f68.Length; y++)
            {
                f68Lengths[y] = ((f68[y].Length < 10) ? $"0{f68[y].Length}" : $"{f68[y].Length}") + $";{f68[y]}";
            }
            Array.Sort(f68Lengths);
            Console.WriteLine($"Legrövidebb szó: {f68Lengths[0].Split(";")[1]}");
        }
        static void F69()
        {
            string[] f69 = File.ReadAllLines("forras69.be");
            int g = 0;
            foreach (string ize in f69) if (ize.Substring(0, 1) != "a") g++;
            string[] f69_notA = new string[g];
            g = 0;
            for (int e = 0; e < f69.Length; e++)
            {
                if (f69[e].Substring(0, 1) != "a")
                {
                    f69_notA[g] = f69[e];
                    g++;
                }
            }
            Console.WriteLine($"Nem 'a' betűvel kezdődő szavak: {string.Join(", ", f69_notA)}");
        }
        static void F70()
        {
            Console.WriteLine("a)");
            int[] f70 = IntList(70);
            int sum = 0;
            int avg = 0;
            foreach (int z in f70)
            {
                sum += z;
                avg += z;
            }
            float avg2 = avg / f70.Length;
            int sumString = int.Parse(sum.ToString().Substring(sum.ToString().Length - 2, 2));
            int sum2 = sum - sumString;
            if (sumString >= 50) sum2 += 100;
            Console.WriteLine($"Átlag: {avg2}\nÖsszeg 100-ra kerekítve: {sum2}");
            Console.WriteLine("b)");
            sum = 0;
            avg = 0;
            List<int> primes = new();
            foreach (int z in f70) if (z > avg) avg = z;
            for (int lift = 2; lift <= avg; lift++) if (IsPrime(lift))
            {
                sum++;
                primes.Add(lift);
            }
            Console.WriteLine($"A tömbben {sum} prímszám van.");
            Console.WriteLine("c)");
            List<int> veryLow = new();
            foreach (int z in f70)
            {
                if (z % 2 == 0 && z < primes[0]) veryLow.Add(z);
            }
            sum = 0;
            foreach (int z in veryLow) sum += z;
            Console.WriteLine($"A legkisebb prímszám ({primes[0]}) előtt álló páros számok átlaga: {sum / veryLow.Count}");
            Console.WriteLine("d)");
            avg = 0;
            foreach (int z in f70) if (z > primes[0] && z < primes[1] && IsPrime(z)) avg++;
            Console.WriteLine($"Az 1. ({primes[0]}) és 2. ({primes[1]}) közötti számok összege: {avg}");
            Console.WriteLine("e)");
            int[] biggest = new int[2];
            int[] smallest = new int[2];
            sum = 0;
            for (int x = 0; x < f70.Length; x++)
            {
                if (f70[x] > sum)
                {
                    sum = f70[x];
                    biggest = [x + 1, sum];
                }
            }
            for (int x = 0; x < f70.Length; x++)
            {
                if (f70[x] < sum)
                {
                    sum = f70[x];
                    smallest = [x + 1, sum];
                }
            }
            Console.WriteLine($"Legkisebb szám sorszáma: {smallest[0]}.\nLegnagyobb szám sorszáma: {biggest[0]}.");
            Console.WriteLine($"f)\nA számok terjedelme: {biggest[1]} - {smallest[1]} = {biggest[1] - smallest[1]}");
        }
        static bool IsPrime(int x)
        {
            int sum = 0;
            for (int c = 1; c <= x; c++) if (x % c == 0) sum += c;
            return x == sum - 1;
        }
        static int[] IntList(int x, int modulus = 1)
        {
            string[] y = File.ReadAllLines($"forras{x}.be");
            int[] z = new int[y.Length];
            for (int g = 0; g < y.Length; g++) if (int.Parse(y[g]) % modulus == 0) z[g] = int.Parse(y[g]);
            return z;
        }
        static string[] DataConvert(string x)
        {
            string[] y = File.ReadAllLines(x);
            string[] w = new string[int.Parse(y[0])];
            for (int z = 1; z < y.Length; z++) w[z - 1] = y[z];
            return w;
        }
        static int InputNumber(string x)
        {
            Console.Write(x);
            try
            {
                return int.Parse(Console.ReadLine());
            } catch
            {
                return 0;
            }
        }
        static string InputString(string x)
        {
            Console.Write(x);
            return Console.ReadLine();
        }
        static void Main()
        {
            /*Console.WriteLine("1. feladat");
            F1();
            Console.WriteLine("\n2. feladat");
            F2();
            Console.WriteLine("\n3. feladat");
            F3();
            Console.WriteLine("\n4. feladat");
            F4();
            Console.WriteLine("\n5. feladat");
            F5();
            Console.WriteLine("\n6. feladat");
            F6();
            Console.WriteLine("\n7. feladat");
            F7();
            Console.WriteLine("\n8. feladat");
            F8();
            Console.WriteLine("\n9. feladat");
            F9();
            Console.WriteLine("\n10. feladat");
            F10();
            Console.WriteLine("\n11. feladat");
            F11();
            Console.WriteLine("\n12. feladat");
            F12();
            Console.WriteLine("\n13. feladat");
            F13();
            Console.WriteLine("\n14. feladat");
            F14();
            Console.WriteLine("\n15. feladat");
            F15();
            Console.WriteLine("\n16. feladat");
            F16();
            Console.WriteLine("\n17. feladat");
            F17();
            Console.WriteLine("\n18. feladat");
            F18();
            Console.WriteLine("\n19. feladat");
            F19();
            Console.WriteLine("\n20. feladat");
            F20();
            Console.WriteLine("\n21. feladat");
            F21();
            Console.WriteLine("\n22. feladat");
            F22();
            Console.WriteLine("\n23. feladat");
            F23();
            Console.WriteLine("\n24. feladat");
            F24();
            Console.WriteLine("\n25. feladat");
            F25();
            Console.WriteLine("\n26. feladat");
            F26();
            Console.WriteLine("\n27. feladat");
            F27();
            Console.WriteLine("\n28. feladat");
            F28();
            Console.WriteLine("\n29. feladat");
            F29();
            Console.WriteLine("\n30. feladat");
            F30();
            Console.WriteLine("\n31. feladat");
            F31();
            Console.WriteLine("\n32. feladat");
            F32();
            Console.WriteLine("\n33. feladat");
            F33();
            Console.WriteLine("\n34. feladat");
            F34();
            Console.WriteLine("\n35. feladat");
            F35();
            Console.WriteLine("\n36. feladat");
            F36();
            Console.WriteLine("\n37. feladat");
            F37();
            Console.WriteLine("\n38. feladat");
            F38();
            Console.WriteLine("\n39. feladat");
            F39();
            Console.WriteLine("\n40. feladat");
            F40();
            Console.WriteLine("\n41. feladat");
            F41();
            Console.WriteLine("\n42. feladat");
            F42();
            Console.WriteLine("\n43. feladat");
            F43();
            Console.WriteLine("\n44. feladat");
            F44();
            Console.WriteLine("\n45. feladat");
            F45();
            Console.WriteLine("\n46. feladat");
            F46();
            Console.WriteLine("\n47. feladat");
            F47();
            Console.WriteLine("\n48. feladat");
            F48();
            Console.WriteLine("\n49. feladat");
            F49();
            Console.WriteLine("\n50. feladat");
            F50();
            Console.WriteLine("\n51. feladat");
            F51();
            Console.WriteLine("\n52. feladat");
            F52();
            Console.WriteLine("\n53. feladat");
            F53();
            Console.WriteLine("\n54. feladat");
            F54();
            Console.WriteLine("\n55. feladat");
            F55();
            Console.WriteLine("\n56. feladat");
            F56();
            Console.WriteLine("\n57. feladat");
            F57();*/
            Console.WriteLine("\n58. feladat");
            F58();
            Console.WriteLine("\n59. feladat");
            F59();
            Console.WriteLine("\n60. feladat");
            F60();
            Console.WriteLine("\n61. feladat");
            F61();
            Console.WriteLine("\n62. feladat");
            F62();
            Console.WriteLine("\n63. feladat");
            F63();
            Console.WriteLine("\n64. feladat");
            F64();
            Console.WriteLine("\n65. feladat");
            F65();
            Console.WriteLine("\n66. feladat");
            F66();
            Console.WriteLine("\n67. feladat");
            F67();
            Console.WriteLine("\n68. feladat");
            F68();
            Console.WriteLine("\n69. feladat");
            F69();
            Console.WriteLine("\n70. feladat");
            F70();
        }
    }
}
