using System.Collections.Generic;

namespace LoveLetter.Logic.Models {
    public interface IPlayer {
        string Name { get; }
        ICard Hand { get; set; }
        bool CanTarget { get; }
        IList<ICard> Discarded { get; }

        void ForceDiscard();
        void MakeUntargetable();
        void RemoveFromRound();
    }
}
