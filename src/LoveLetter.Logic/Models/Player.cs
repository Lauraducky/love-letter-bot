using System.Collections.Generic;

namespace LoveLetter.Logic.Models {
    class Player : IPlayer {
        private IDeck _deck;

        public string Name { get; }
        public ICard Hand { get; set; }
        public bool CanTarget { get; private set; } = true;
        public IList<ICard> Discarded { get; } = new List<ICard>();

        public Player(string name, IDeck deck) {
            Name = name;
            _deck = deck;
        }

        public void ForceDiscard() {
            bool safe = Hand.ForceDiscard();

            if (!safe) {
                RemoveFromRound();
                return;
            }

            Hand = _deck.Draw();
        }

        public void MakeUntargetable() {
            CanTarget = false;
        }

        public void RemoveFromRound() {
            Discarded.Add(Hand);
            Hand = null;
            // TODO Remove from round
        }
    }
}
