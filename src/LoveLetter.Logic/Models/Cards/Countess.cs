namespace LoveLetter.Logic.Models.Cards {
    public class Countess : ICardBasic {
        public int Value => 7;

        public bool MustBeDiscarded(ICard card) {
            if (card is King || card is Prince) {
                return true;
            }

            return false;
        }

        public bool ForceDiscard() {
            return true;
        }

        public bool Discard(IPlayer player) {
            return true;
        }

        public bool Discard(object[] args) {
            return Discard((IPlayer)args[0]);
        }
    }
}
