using System;
using Workle.Models;

namespace Workle.Service.Checks
{
    public class Checker : IChecker
    {
        public void CheckPutOnCard(Card card)
        {
            if (card.Bin == 445199)
                Console.WriteLine("Пополнение запрещено(BIN == 445199)");
            else if (card.Brand == "VISA")
                Console.WriteLine("Пополнение запрещено(BRAND == VISA)");
            else if (card.BinLevel == "ELECTRON")
                Console.WriteLine("Пополнение запрещено(BRAND == ELECTRON)");
            else
                Console.WriteLine("Пополнение разрешено");
        }

        public void CheckWithdrawFromCard(Card card)
        {
            if (card.BinType == "CREDIT")
                Console.WriteLine("Списание запрещено(BIN_TYPE == CREDIT)");
            else if (card.BinLevel == "SIGNATURE")
                Console.WriteLine("Списание запрещено(BIN_LEVEL = SIGNATURE)");
            else if (card.Contry2Iso != "RUS")
                Console.WriteLine("Списание запрещено(COUNTRY2_ISO != RUS)");
            else
                Console.WriteLine("Списание разрешено");
        }
    }
}