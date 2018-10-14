using System;

namespace LoveLetter.Logic.Models.Cards {
    public class Guard : ICardTargetCard {
        public int Value => 1;

        public bool MustBeDiscarded(ICard card) {
            return false;
        }

        public bool ForceDiscard() {
            return true;
        }

        public bool Discard(IPlayer player, IPlayer target, ICard card) {
            if (card.Value == 1) {
                throw new Exception("Attempt to target guard with guard.");
            }

            if (!target.CanTarget) {
                throw new Exception("Attempt to target protected player.");
            }

            if (target.Hand.Value == card.Value) {
                target.RemoveFromRound();
            }

            return true;
        }

        public bool Discard(object[] args) {
            if (args.Length != 3) {
                throw new ArgumentException("Wrong number of arguments.");
            }

            if (args[0] is IPlayer player && args[1] is IPlayer target && args[1] is ICard card) {
                return Discard(player, target, card);
            }

            throw new ArgumentException("Arguments of incorrect type provided");
        }
    }
}
