using System.ComponentModel.DataAnnotations;
bool v;
v = true;
do
{
    while (v != false)
    {
        Console.WriteLine("выберите операцию: +, -, *, /, sqrt, ^, 1%, fact, exit");
        string a = Console.ReadLine();
        if (a == "+")
        {
            string c = Console.ReadLine();
            double g = Convert.ToDouble(c);
            string d = Console.ReadLine();
            double e = Convert.ToDouble(d);
            Console.WriteLine(g + e);
            continue;
        }
        else if (a == "-")
        {
            string c = Console.ReadLine();
            double g = Convert.ToDouble(c);
            string d = Console.ReadLine();
            double e = Convert.ToDouble(d);
            Console.WriteLine(g - e);
            continue;
        }
        else if (a == "*")
        {
            string c = Console.ReadLine();
            double g = Convert.ToDouble(c);
            string d = Console.ReadLine();
            double e = Convert.ToDouble(d);
            Console.WriteLine(g * e);
            continue;
        }
        else if (a == "/")
        {
            string c = Console.ReadLine();
            double g = Convert.ToDouble(c);
            string d = Console.ReadLine();
            double e = Convert.ToDouble(d);
            if (e == 0)
            {
                Console.WriteLine("На 0 делить нельзя,гений");
            }
            else
                Console.WriteLine(g / e);
            continue;
        }
        else if (a == "^")
        {
            string c = Console.ReadLine();
            double g = Convert.ToInt32(c);
            string d = Console.ReadLine();
            double e = Convert.ToInt32(d);
            Console.WriteLine(Math.Pow(g, e));
            continue;
        }
        else if (a == "1%")
        {
            string c = Console.ReadLine();
            double g = Convert.ToDouble(c);
            double d = 100;
            Console.WriteLine(g/d);
            continue;
        }
        else if (a == "sqrt")
        {

            string c = Console.ReadLine();
            double g = Convert.ToDouble(c);
            if (g <= 0) 
            {
                Console.WriteLine("Отрицательного корня нет и корня 0");
            }
            else
            {
                Console.WriteLine(Math.Sqrt(g));
            }
        }
        else if (a == "fact")
        {
            string c = Console.ReadLine();
            int g = Convert.ToInt32(c);
            int f;
            int t;
            int j;
            j = g;
            if (g < 0)
            {
                Console.WriteLine("нельзя отрицательное число");
            }
            else
            {
                do
                {
                    t = j;
                    f = j * (g-1);
                    g--;
                    j = f;
                } while (g != 0);
                Console.WriteLine(t);
            }
        }
        else if (a == "exit")
        {
            v = false;
            Console.WriteLine("пока(");
        }
        else
        {
            Console.WriteLine("неверный оператор");
        }
    }
} while (v == true);