using System;

namespace _3._1
{
    class Program
    {
        public void f(int x)
        {
            int a, b, c;
            a = x / 100;
            b = (x / 10) % 10;
            c = x % 10;
            Console.WriteLine(c + "" + b + "" + a);
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите трёхзнач число ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 100 || x > 999) Console.WriteLine("Неккоректные введённые данные");
            else
            {
                Program m = new Program();
                m.f(x);
            }
        }
    }
}
