using System.Globalization;

namespace ChallengeBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();

            Console.Write("Sexo: ");
            bill.gender = char.Parse(Console.ReadLine());

            Console.Write("Quantidade de cervejas: ");
            bill.beer= int.Parse(Console.ReadLine());

            Console.Write("Quantidade de refrigerantes: ");
            bill.softDrink = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de espetinhos: ");
            bill.barbecue = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO:");
            Console.WriteLine($"Consumo = R$ {bill.Feeding().ToString("F2", CultureInfo.InvariantCulture)}");

            if (bill.Cover() > 0.0)
            {
                Console.WriteLine($"Couvert = R$ {bill.Cover().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Isento de Couvert");
            }
            
            Console.WriteLine($"Ingresso = R$ {bill.Ticket().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.WriteLine($"Valor a pagar = R$ {bill.Total().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
