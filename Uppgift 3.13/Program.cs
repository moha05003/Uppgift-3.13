namespace Uppgift_3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder < 16)
            {
                Console.WriteLine(" Du är för ung");
            }
            if (ålder > 19)
            {
                Console.WriteLine("Du är få gammal");

            }
            else if (ålder >=16 && ålder <=19)
            {
                Console.WriteLine("Du är få delta i tävlingen");

            }






        }
    }
} 