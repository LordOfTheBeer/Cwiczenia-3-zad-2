namespace Zad2_w_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int n;

            int s = 0;

            int i = 1;

            Console.WriteLine("Ile liczb chcesz dodać?");

            n=int.Parse(Console.ReadLine());

            while (i <=n)
            { Console.WriteLine("i = " + i + "\t s = " + s);
                s += i;
                i++;
            }
            Console.WriteLine("Suma = " + s);
            
                    
            
        }
    }
}