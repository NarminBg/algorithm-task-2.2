using System.Reflection.PortableExecutable;

namespace algorithm_task_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int character;
            while (number!=0)
            {
                character = number % 10;
                number /= 10;

                if (character==0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
           
        }
    }
}