using System;
using Workle.Service;
using Workle.Service.CardReaders;
using Workle.Service.Checks;

namespace Workle
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "data.txt";
            var cardReader = new CardReaderJson(path);
            var cheker = new Checker();
            var monitoringService = new FraudMonitoringService(cardReader);
            int management;

            while (true)
            {
                Console.WriteLine("Если хотите провести мониторинг карты, введите 1");
                Console.WriteLine("Если ничего не хотите, введите 0");
                management = Convert.ToInt32(Console.ReadLine());
                if (management == 1)
                {
                    Console.WriteLine("Введите bin");
                    var bin = Convert.ToInt32(Console.ReadLine());
                    if (bin > 99999 && bin < 1000000)
                    {
                        monitoringService.PutOnCard(bin, cheker);
                        monitoringService.WithdrawFromCard(bin, cheker);
                    }
                    else
                    {
                        Console.WriteLine("Некорректно введен bin(bin должен содержать 6 цифр)");
                    }

                }
                if (management == 0)
                    break;
            }
        }
    }
}