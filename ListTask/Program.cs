using Core;

namespace ListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            int choice;
            do
            {
                Console.WriteLine("1.Product yaratmag:\n2.Type-a gore filtrle:");
                if (int.TryParse(Console.ReadLine(),out choice))
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Product-in no-sunu daxil edin:");
                        int no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Productin adinin daxil edin:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Productin qiymetini daxil edin:");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Productin type ni daxil edin:");
                        string type = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("");
                            break;
                }
            } 
            while (true);
        }
    }
}