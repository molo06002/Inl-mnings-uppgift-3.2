using System;
namespace inlämningsuppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?, j eller n: ");
            string x = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?: ");
            string y = Console.ReadLine();
            int R = Convert.ToInt32(y);
            if (R <= 22 && x == "j")
            {
                Console.WriteLine("Du är kvalificerad för jobbet!");
            }
            else
            {
                Console.WriteLine("Du är tyvärr inte kvalificerad för jobbet!");
            }
        }
    }
}