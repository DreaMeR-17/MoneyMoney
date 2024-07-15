using System;

namespace MoneyMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rublesInWallet;
            float dollarsInWallet;
            float eurosInWallet;

            int rubToDollar = 85, dollarToRub = 87;
            int rubToEuro = 93, euroToRub = 95;
            float dollarToEuro = 0.91f, euroToDollar = 1.09f;

            float exchangeCurrencyCount;

            string desiredOperation;

            const string RubToDollar = "1";
            const string DollarToRub = "2";
            const string RubToEuro = "3";
            const string EuroToRub = "4";
            const string DollarToEuro = "5";
            const string EuroToDollar = "6";
            const string Exit = "7";
            const string ConsoleClear = "8";

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
                Console.WriteLine($"{RubToDollar} - обменять рубли на доллары");
                Console.WriteLine($"{DollarToRub} - обменять доллары на рубли");
                Console.WriteLine($"{RubToEuro} - обменять рубли на евро");
                Console.WriteLine($"{EuroToRub} - обменять евро на рубли");
                Console.WriteLine($"{DollarToEuro} - обменять доллары на евро");
                Console.WriteLine($"{EuroToDollar} - обменять евро на доллары");
                Console.WriteLine($"{Exit} - выход из обменника");
                Console.WriteLine($"{ConsoleClear} - очистить консоль");
                desiredOperation = Console.ReadLine();

                switch (desiredOperation)
                {
                    case RubToDollar:
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if(rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            dollarsInWallet += exchangeCurrencyCount / rubToDollar;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case DollarToRub:
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

                    case RubToEuro:
                        Console.WriteLine("Обмен рублей на Евро");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            eurosInWallet += exchangeCurrencyCount / rubToEuro;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case EuroToRub:
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

                    case DollarToEuro:
                        Console.WriteLine("Обмен долларов на Евро");
                        Console.Write("Сколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (dollarsInWallet >= exchangeCurrencyCount)
                        {
                            dollarsInWallet -= exchangeCurrencyCount;
                            eurosInWallet += exchangeCurrencyCount / dollarToEuro;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                        }
                        break;

                    case EuroToDollar:
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

                    case Exit:
                        isWork = false;
                        break;

                    case ConsoleClear:
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
