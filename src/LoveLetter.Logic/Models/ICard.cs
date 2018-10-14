namespace LoveLetter.Logic.Models {
    public interface ICard {
        int Value { get; }

        bool MustBeDiscarded(ICard card);
        bool ForceDiscard();
        bool Discard(object[] args);
    }
}
