namespace LoveLetter.Logic.Models {
    public interface ICardTarget : ICard {
        bool Discard(IPlayer player, IPlayer target);
    }
}
