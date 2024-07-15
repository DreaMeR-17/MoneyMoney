using System;

namespace MoneyMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandRubToDollar = "1";
            const string CommandDollarToRub = "2";
            const string CommandRubToEuro = "3";
            const string CommandEuroToRub = "4";
            const string CommandDollarToEuro = "5";
            const string CommandEuroToDollar = "6";
            const string CommandExit = "7";
            const string CommandConsoleClear = "8";

            string desiredOperation;

            float rublesInWallet;
            float dollarsInWallet;
            float eurosInWallet;

            float exchangeCurrencyCount;

            float rubToDollar = 0.012f;
            float dollarToRub = 87;
            float rubToEuro = 0.01f;
            float euroToRub = 95;
            float dollarToEuro = 0.91f;
            float euroToDollar = 1.09f;

            bool isWork = true;

            Console.WriteLine("Обменник валют");

            Console.Write("Введите баланс рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс евро: ");
            eurosInWallet = Convert.ToSingle(Console.ReadLine());

            while (isWork)
            {
                Console.WriteLine("Выберите нужную вам операцию.");
                Console.WriteLine($"{CommandRubToDollar} - обменять рубли на доллары");
                Console.WriteLine($"{CommandDollarToRub} - обменять доллары на рубли");
                Console.WriteLine($"{CommandRubToEuro} - обменять рубли на евро");
                Console.WriteLine($"{CommandEuroToRub} - обменять евро на рубли");
                Console.WriteLine($"{CommandDollarToEuro} - обменять доллары на евро");
                Console.WriteLine($"{CommandEuroToDollar} - обменять евро на доллары");
                Console.WriteLine($"{CommandExit} - выход из обменника");
                Console.WriteLine($"{CommandConsoleClear} - очистить консоль");
                desiredOperation = Console.ReadLine();

                switch (desiredOperation)
                {
                    case CommandRubToDollar:
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if(rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            dollarsInWallet += exchangeCurrencyCount * rubToDollar;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case CommandDollarToRub:
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (dollarsInWallet >= exchangeCurrencyCount)
                        {
                            dollarsInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * dollarToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case CommandRubToEuro:
                        Console.WriteLine("Обмен рублей на Евро");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            eurosInWallet += exchangeCurrencyCount * rubToEuro;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case CommandEuroToRub:
                        Console.WriteLine("Обмен Евро на рубли");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (eurosInWallet >= exchangeCurrencyCount)
                        {
                            eurosInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * euroToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case CommandDollarToEuro:
                        Console.WriteLine("Обмен долларов на Евро");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (dollarsInWallet >= exchangeCurrencyCount)
                        {
                            dollarsInWallet -= exchangeCurrencyCount;
                            eurosInWallet += exchangeCurrencyCount * dollarToEuro;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case CommandEuroToDollar:
                        Console.WriteLine("Обмен Евро на доллары");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (eurosInWallet >= exchangeCurrencyCount)
                        {
                            eurosInWallet -= exchangeCurrencyCount;
                            dollarsInWallet += exchangeCurrencyCount * euroToDollar;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case CommandExit:
                        isWork = false;
                        break;

                    case CommandConsoleClear:
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Выбрана неверная операция");
                        break;
                }

                Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей, {dollarsInWallet} долларов и {eurosInWallet} евро.");
            }
        }
    }
}
