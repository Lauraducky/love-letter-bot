namespace LoveLetter.Logic.Models {
    public interface ICardBasic : ICard {
        bool Discard(IPlayer player);
    }
}
