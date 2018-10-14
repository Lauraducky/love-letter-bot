namespace LoveLetter.Logic.Models.Cards {
    public class Princess : ICardBasic {
        public int Value => 8;

        public bool MustBeDiscarded(ICard card) {
            return false;
        }

        public bool ForceDiscard() {
            return false;
        }

        public bool Discard(IPlayer player) {
            return false;
        }

        public bool Discard(object[] args) {
            return Discard((IPlayer)args[0]);
        }
    }
}
