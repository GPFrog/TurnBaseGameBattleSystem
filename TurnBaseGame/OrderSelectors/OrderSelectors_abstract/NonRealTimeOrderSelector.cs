using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem.OrderSelectors.OrderSelectors_abstract
{
    abstract class NonRealTimeOrderSelector : IOrderSelecter
    {
        protected ICollection<IComparable> battleActors;
        public abstract IActable getCurrentTurnActor();

        public int GetCountOfActor()
        {
            return battleActors.Count;
        }

        protected abstract void SortActors();
    }
}
