namespace LoveLetter.Logic.Models.Cards {
    public class Handmaid : ICardBasic {
        public int Value => 4;

        public bool MustBeDiscarded(ICard card) {
            return false;
        }

        public bool ForceDiscard() {
            return true;
        }

        public bool Discard(IPlayer player) {
            player.MakeUntargetable();
            return true;
        }

        public bool Discard(object[] args) {
            return Discard((IPlayer)args[0]);
        }
    }
}
