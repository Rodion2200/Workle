using System;
using Workle.Service.CardReaders;
using Workle.Service.Checks;

namespace Workle.Service
{
    public class FraudMonitoringService
    {
        private readonly ICardReader _cardReader;

        public FraudMonitoringService(ICardReader cardReader)
        {
            _cardReader = cardReader;
        }

        public void PutOnCard(int bin, IChecker cheked)
        {
            var card = _cardReader.GetCardOrNull(bin);

            if (card == null)
                Console.WriteLine("Проверить возможность пополнения карты не получилось(карта не найдена)");
            else
                cheked.CheckPutOnCard(card);
        }

        public void WithdrawFromCard(int bin, IChecker cheked)
        {
            var card = _cardReader.GetCardOrNull(bin);

            if (card == null)
                Console.WriteLine("Проверить возможность списания с карты не получилось(карта не найдена)");
            else
                cheked.CheckWithdrawFromCard(card);
        }
    }
}