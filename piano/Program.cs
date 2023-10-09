using System.Linq;

namespace piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool g = true;
            do
            {
                Console.WriteLine("Выберите октаву F1 - шестая, F2 - седьмая, F3 - восьмая, Z - смена октаву, ESC - закрыть программу");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.F1)
                {
                    int[] octava = octavafirst();
                    klavishi(octava);
                }
                if (a.Key == ConsoleKey.F2)
                {
                    int[] octava = octavasecond();
                    klavishi(octava);
                }
                if (a.Key == ConsoleKey.F3)
                {
                    int[] octava = octavathird();
                    klavishi(octava);
                }
                if (a.Key == ConsoleKey.Escape)
                {
                    g = false;
                }
            } while (g == true);
        }
        static int[] Octava1()
        {
            int[] octava = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            return octava;
        }
        static int[] octava2()
        {
            int[] octava = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            return octava;
        }
        static int[] octava3()
        {
            int[] octava = new int[] { 4186, 4435, 4699,4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            return octava;
        }
        static int[] octavafirst()
        {
            Console.WriteLine("Октава 6");
            int[] octava = Octava1();
            return octava;
        }
        static int[] octavasecond()
        {
            Console.WriteLine("Октава 7");
            int[] octava = octava2();
            return octava;
        }
        static int[] octavathird()
        {
            Console.WriteLine("Октава 8");
            int[] octava = octava3();
            return octava;
        }
        static void klavishi(int[] octava)
        {
            while (true) 
            {
                ConsoleKeyInfo a = Console.ReadKey();
                Console.Clear();
                if (a.Key == ConsoleKey.Z)
                {
                    break;
                }
                switch (a.Key)
                {
                    case ConsoleKey.A:
                        int b = octava[0];
                        Console.Beep(b, 800);
                        break;
                    case ConsoleKey.Q:
                        int q = octava[1];
                        Console.Beep(q, 800);
                        break;
                    case ConsoleKey.S:
                        int s = octava[2];
                        Console.Beep(s, 800);
                        break;
                    case ConsoleKey.D:
                        int f = octava[3];
                        Console.Beep(f, 800);
                        break;
                    case ConsoleKey.E:
                        int g = octava[4];
                        Console.Beep(g, 800);
                        break;
                    case ConsoleKey.F:
                        int h = octava[5];
                        Console.Beep(h, 800);
                        break;
                    case ConsoleKey.G:
                        int w = octava[6];
                        Console.Beep(w, 800);
                        break;
                    case ConsoleKey.R:
                        int r = octava[7];
                        Console.Beep(r, 800);
                        break;
                    case ConsoleKey.H:
                        int j = octava[8];
                        Console.Beep(j, 800);
                        break;
                    case ConsoleKey.T:
                        int t = octava[9];
                        Console.Beep(t, 800);
                        break;
                    case ConsoleKey.J:
                        int k = octava[10];
                        Console.Beep(k, 800);
                        break;
                    case ConsoleKey.U:
                        int v = octava[11];
                        Console.Beep(v, 800);
                        break;
                    case ConsoleKey.K:
                        int l = octava[12];
                        Console.Beep(l, 800);
                        break;
                }
            } 
        }
    }
}