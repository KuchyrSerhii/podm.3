using System;

namespace podm._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte číslo k odmocnění");
            string z_klavesnice = Console.ReadLine();
            double k_odmocneni = Convert.ToDouble(z_klavesnice);
            if (k_odmocneni > 0)
                Console.WriteLine("Zadal jsi číslo větší než 0 a já ho můžu odmocnit");
            double odmocnina = Math.Sqrt(k_odmocneni);
            Console.WriteLine("odmocnina z cisla  " + k_odmocneni + " je " + odmocnina);
            if (k_odmocneni <= 0)
                Console.WriteLine("Odmocnina ze záporného čísla neexistuje!");
            Console.ReadKey();
        }
    }
}
