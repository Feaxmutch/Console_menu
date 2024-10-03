namespace Console_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandWriteHello = "1";
            const string CommandWriteSelfClassName = "2";
            const string CommandWriteARandomNumber = "3";
            const string CommandClear = "4";
            const string CommandExit = "5";

            bool isRunning = true;
            Random random = new();

            while (isRunning)
            {
                Console.WriteLine($"{CommandWriteHello}) Вывести \"Привет\"");
                Console.WriteLine($"{CommandWriteSelfClassName}) Вывести имя своего класса");
                Console.WriteLine($"{CommandWriteARandomNumber}) Вывести случайное число");
                Console.WriteLine($"{CommandClear}) Очистить консоль");
                Console.WriteLine($"{CommandExit}) Завершить работу программы");
                string userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case CommandWriteHello:
                        Console.WriteLine("Привет");
                        break;

                    case CommandWriteSelfClassName:
                        Console.WriteLine(typeof(Program).Name);
                        break;

                    case CommandWriteARandomNumber:
                        Console.WriteLine(random.Next(int.MinValue, int.MaxValue));
                        break;

                    case CommandClear:
                        Console.Clear();
                        break;

                    case CommandExit:
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
