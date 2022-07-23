using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    interface IActable
    {
        public void act();
    }

    interface IActableOnceAtOneRound : IActable, IComparable
    {
        public bool HasActed();
    }

    interface ISpeed
    {
        public int Speed { get; set; }
    }

    interface IActorAddable
    {
        public void AddActor(IActable actable);
    }

    interface IOrderSelecter
    {
        public IActable getCurrentTurnActor();
        public int GetCountOfActor();
    }
}
