
       namespace Transaction
    {
        internal class Program
        {
            static int count = 0;

            static string[] company = new string[100];
            static string[] item = new string[100];
            static double[] price = new double[100];
            static double[] sellprice = new double[100];
            static int[] stock = new int[100];

            static void Main(string[] args)
            {
                Console.WriteLine("Company Transactions from Vendors.");
                while (true)
                {
                    int choice = 0;

                    Console.WriteLine("1 = Add items \n2 = View Stocks \n3 = Update \n4 = Delete \n5= Exit");
                    Console.WriteLine("Please Input Your choice: ");

                    choice = Convert.ToInt16(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Company Name: ");
                        company[count] = Console.ReadLine();

                        Console.Write("Item Name: ");
                        item[count] = Console.ReadLine();

                        Console.Write("Purchase Price: ");
                        price[count] = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Selling Price: ");
                        sellprice[count] = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Stocks: ");
                        stock[count] = Convert.ToInt16(Console.ReadLine());

                        count++;

                        Console.WriteLine("Item Added Successfully");
                    }

                    if (choice == 2)
                    {
                        if (count == 0)
                        {
                            Console.WriteLine("No items available.");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("\nCompany: " + company[i]);
                                Console.WriteLine("Item: " + item[i]);
                                Console.WriteLine("Purchase Price: " + price[i]);
                                Console.WriteLine("Selling Price: " + sellprice[i]);
                                Console.WriteLine("Stocks: " + stock[i]);
                                Console.WriteLine("---------------------------");
                            }
                        }
                    }
                }
            }
        }
    }