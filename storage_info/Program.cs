namespace storage_info
{
    internal class Program
    {
        /*Bread Juice Fruits Lemons Beer
10 50 20 30
2,34 1,23 3,42 1,50 3,00*/
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine()
                .Split()
                .ToArray();
            ulong[] quantity = Console.ReadLine()
                .Split()
                .Select(ulong.Parse)
                .ToArray();
            double[] prices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            string productNameQuantity = Console.ReadLine();
            ulong[] quantities = new ulong[productsNames.Length];
            for(int i =  0; i < quantity.Length; i++)
            {
                quantities[i] = quantity[i];
            }
            while (productNameQuantity != "done")
            {
                int singleProductQuantity = NumExtract(productNameQuantity);
                int productLenght = productNameQuantity.Length-(singleProductQuantity.ToString().Length+1);
                string productName = productNameQuantity.Substring(0,productLenght);
                int unAvailable = 0;
                for (int i = 0; i < productsNames.Length; i++)
                {
                    if (productsNames[i] == productNameQuantity)
                    {
                        Console.WriteLine($"{productsNames[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
                        unAvailable++;
                    }
                    else if (productsNames[i] == productName)
                    {
                        double finalPrice = singleProductQuantity * prices[i];
                        if((ulong)singleProductQuantity > quantities[i])
                        {
                            Console.WriteLine($"We do not have enough {productName}");
                            unAvailable++;
                        }
                        else
                        {
                            Console.WriteLine($"{productName} x {singleProductQuantity} costs {finalPrice:f2}");
                            quantities[i] -= (ulong)singleProductQuantity;
                            unAvailable++;
                        }
                    }
                }
                if( unAvailable == 0 )
                {
                    Console.WriteLine("not in stock!");
                }
                productNameQuantity = Console.ReadLine();
            }
            Console.ReadKey();
        }
        static int NumExtract(string command)
        {
            string num = null;
            int number = 0;
            for (int i = 0; i < command.Length; i++)
            {
                if (Char.IsDigit(command[i]))
                {
                    num += command[i];
                }
            }
            if (num.Length > 0)
            {
                number = int.Parse(num);
            }
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == '-')
                {
                    number = number * (-1);
                }
            }
            return number;
        }
    }
}