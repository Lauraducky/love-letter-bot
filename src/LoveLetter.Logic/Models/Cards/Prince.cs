using System;

namespace LoveLetter.Logic.Models.Cards {
    public class Prince : ICardTarget {
        public int Value => 5;

        public bool MustBeDiscarded(ICard card) {
            return false;
        }

        public bool ForceDiscard() {
            return true;
        }


        public bool Discard(IPlayer player, IPlayer target) {
            if (!target.CanTarget) {
                throw new Exception("Attempt to target protected player.");
            }

            target.ForceDiscard();

            return true;
        }

        public bool Discard(object[] args) {
            if (args.Length != 2) {
                throw new ArgumentException("Wrong number of arguments.");
            }

            if (args[0] is IPlayer player && args[1] is IPlayer target) {
                return Discard(player, target);
            }

            throw new ArgumentException("Arguments of incorrect type provided");
        }
    }
}
