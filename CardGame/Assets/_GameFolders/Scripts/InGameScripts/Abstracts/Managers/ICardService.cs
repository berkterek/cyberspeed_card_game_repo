using CardGame.Abstracts.Controllers;
using Cysharp.Threading.Tasks;

namespace CardGame.Abstracts.Managers
{
    public interface ICardService
    {
        void CreateCards();
        UniTask FlipAllCard();
        void MatchCards(ICardController cardController);
        event System.Action<int> OnSuccessMatching;
        event System.Action<int> OnPlayerPlayCount;
        event System.Action OnGameOvered;
        void LoadLastGameCards();
    }
}