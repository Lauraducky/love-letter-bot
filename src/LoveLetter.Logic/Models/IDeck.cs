namespace LoveLetter.Logic.Models {
    public interface IDeck {
        int CardsLeft { get; }

        ICard Draw();
    }
}
