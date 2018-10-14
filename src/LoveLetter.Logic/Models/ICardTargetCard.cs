namespace LoveLetter.Logic.Models {
    public interface ICardTargetCard : ICard {
        bool Discard(IPlayer player, IPlayer target, ICard card);
    }
}
