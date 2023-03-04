namespace PROYECTO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un Numero Porfavor");
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == -1)
                    break;

                if (num % 2 == 0)
                    Console.WriteLine("Tu Numero es Par");
                else
                    Console.WriteLine("Tu Numero es Impar");

            }
        }
    }
}