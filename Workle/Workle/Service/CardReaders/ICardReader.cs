using Workle.Models;

namespace Workle.Service.CardReaders
{
    public interface ICardReader
    {
       public Card GetCardOrNull(int bin);
    }
}