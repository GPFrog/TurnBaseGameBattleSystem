using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem.OrderSelectors.OrderSelectors_abstract
{
    abstract class RealTimeOrderSelector
    {
        protected IEnumerable<IActable> battleActors;
        public abstract IActable GetCurrentTurnActor();

        public int GetCountOfActor()
        {
            return battleActors.Count();
        }
    }
}
