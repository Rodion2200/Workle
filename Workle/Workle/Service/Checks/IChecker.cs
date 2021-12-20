using Workle.Models;

namespace Workle.Service.Checks
{
    public interface IChecker
    {
        public void CheckWithdrawFromCard(Card card);

        public void CheckPutOnCard(Card card);
    }
}