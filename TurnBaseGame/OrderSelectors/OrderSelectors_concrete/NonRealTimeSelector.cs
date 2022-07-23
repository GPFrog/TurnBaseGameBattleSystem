using BattleSystem.OrderSelectors.OrderSelectors_abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem.OrderSelectors_concrete
{
    class NonRealTimeSelector : NonRealTimeOrderSelector, IActorAddable
    {
        public NonRealTimeSelector(ICollection<IComparable> battleActors)
        {
            base.battleActors = battleActors;
        }

        public void AddActor(IActable actable)
        {
            if (actable is IComparable)
                battleActors.Add((IComparable)actable);
        }

        public override IActable getCurrentTurnActor()
        {
            SortActors();

            List<IActableOnceAtOneRound> actableOnces = new();
            foreach (var battleActor in battleActors)
            {
                if (battleActor is IActableOnceAtOneRound)
                    actableOnces.Add((IActableOnceAtOneRound)battleActor);
            }

            return actableOnces.First(actor => actor.HasActed() == false);
        }

        protected override void SortActors()
        {
            if (battleActors is List<IComparable>)
                ((List<IComparable>)battleActors).Sort();
        }
    }
}
