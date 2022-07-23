using BattleSystem.OrderSelectors.OrderSelectors_abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem.OrderSelectors_concrete
{
    class RealTimeSelector : NonRealTimeOrderSelector, IActorAddable
    {
        public void AddActor(IActable actable)
        {
            throw new NotImplementedException();
        }

        public override IActable getCurrentTurnActor()
        {
            throw new NotImplementedException();
        }

        protected override void SortActors()
        {
            throw new NotImplementedException();
        }
    }
}
