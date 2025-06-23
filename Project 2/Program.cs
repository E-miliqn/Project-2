namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //I етап
            Console.Write("I етап - въвеждане \n nатисни enter");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
            Console.Write("Брой коли: ");
            int n = int.Parse(Console.ReadLine());
            Cars[] cars = new Cars[n];
            cars = InputCarsData(n);
            Console.Write("Брой Нови клиенти: ");
            int x = int.Parse(Console.ReadLine());
            Customers[] customers = new Customers[x];
            customers = InputDataForCustomers(x);
            Console.WriteLine("За втори етап - обработка на данни \n натисни enter: ");
            //II етап
            PrintData1(cars);
            Console.Write("Искаш ли да премахнеш или добавиш кола? true/false: ");
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
            bool removeOrAdd = bool.Parse(Console.ReadLine().ToLower());
            if (removeOrAdd == true)
            {
                Console.Write("индекс: "); 
                int input = int.Parse(Console.ReadLine());
                RemoveCar(cars, input);
            }
            Console.WriteLine("================================================");
            PrintCustomersData(customers);
            //III етап
            Console.WriteLine("трети етап - изчисления - натисни enter");
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
            AvaregeCar(cars, n);
            Max(cars);


            static Cars[] InputCarsData(int n)
            {
                Cars[] cars = new Cars[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Въведете данни за кола {i + 1} (рег. номер, марка, модел, цена, година): ");
                    List<string> input = new List<string>(Console.ReadLine().Split(", "));
                    string registNumber = input[0];
                    string mark = input[1];
                    string model = input[2];
                    double price = double.Parse(input[3]);
                    int year = int.Parse(input[4]);
                    cars[i] = new Cars(registNumber, mark, model, price, year);
                }
                return cars;

            }

            static Customers[] InputDataForCustomers(int x)
            {

                Customers[] customers = new Customers[x];
                for (int i = 0; i < x; i++)
                {
                    Console.Write($"Въведете данни за клиент {i + 1} (номер, име, фамилия, година на раждане, бюджет): ");
                    List<string> input = new List<string>();
                    input = Console.ReadLine().Split(", ").ToList();
                    int number = int.Parse(input[0]);
                    string firstName = input[1];
                    string lastName = input[2];
                    int birthYear = int.Parse(input[3]);
                    double budget = double.Parse(input[4]);
                    customers[i] = new Customers(number, firstName, lastName, birthYear, budget);
                }
                return customers;
            }
        }
        static void AvaregeCar(Cars[] cars, int n)
        {
            Console.WriteLine("Средна цена на колите: ");
            int sum = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                sum += cars[i].Year;
            }
            int average = sum / n;
            Console.WriteLine($"{average} = средна сума");
        }
        static void Max(Cars[] cars)
        {
            double max2 = 0.0;
            int max1 = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Year > max1)
                {
                    max1 = cars[i].Year;
                }
                if (cars[i].Year == max1)
                {
                    Console.WriteLine($"{i+1} кола е най-нова");
                    Console.WriteLine($"{cars[i].Mark}, {cars[i].Model}, {cars[i].Price}, {cars[i].Year}");
                }
            }
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Price > max2)
                {
                    max2 = cars[i].Price;
                }
                if (cars[i].Price == max2)
                {
                    Console.WriteLine($"{i+1} кола е с най-висока цена ");
                    Console.WriteLine($"{cars[i].Mark}, {cars[i].Model}, {cars[i].Price}, {cars[i].Year}");
                }
            }
        }
        static void PrintData1(Cars[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Кола {i + 1}");
                Console.WriteLine($"{cars[i].Mark} {cars[i].Model}");

            }
        }
        static void PrintCustomersData(Customers[] customers)
        {
            for (int i = 0; i < customers.Length; i++)
            {
                Console.Write($"Клиент {1 + 1}");
                Console.WriteLine($"{customers[i].Number} {customers[i].FirstName} {customers[i].LastName} {customers[i].BirthYear} {customers[i].Budget}");
            }
        }
        static void RemoveCar(Cars[] cars, int inputt)
        {
            Console.WriteLine($"за update напиши \"Update\", а за изтриване \"delete\"");
            string action = Console.ReadLine().ToLower();
            for (int i = 0; i < cars.Length; i++)
            {
                if (i == inputt)
                {
                    if (action == "delete")
                    {
                        cars[i] = null;
                        Console.WriteLine($"Колата с индекс {i} е изтрита.");
                    }
                    else if (action == "update")
                    {
                        Console.Write("Въведете нови данни за колата (рег. номер, марка, модел, цена, година):");
                        List<string> input = new List<string>(Console.ReadLine().Split(", "));
                        string registNumber = input[0];
                        string mark = input[1];
                        string model = input[2];
                        double price = double.Parse(input[3]);
                        int year = int.Parse(input[4]);
                        cars[i] = new Cars(registNumber, mark, model, price, year);
                        Console.WriteLine($"Колата с индекс {i} е обновена.");
                    }
                }
            }

        }
    }
}
