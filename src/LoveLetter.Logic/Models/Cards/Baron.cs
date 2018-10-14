﻿using System;

namespace LoveLetter.Logic.Models.Cards {
    public class Baron : ICardTarget {
        public int Value => 3;

        public bool MustBeDiscarded(ICard card) {
            return false;
        }

        public bool ForceDiscard() {
            return true;
        }

        public bool Discard(IPlayer player, IPlayer target) {
            if (player.Hand.Value < target.Hand.Value) {
                return false;
            }

            target.RemoveFromRound();
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
