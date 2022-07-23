using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class NonRealTimeBattleActor : IActableOnceAtOneRound, ISpeed
    {
        public int Speed { get; set; }
        private bool hasActed;

        public NonRealTimeBattleActor(int speed, bool hasActed = false)
        {
            Speed = speed;
            this.hasActed = hasActed;
        }



        public bool HasActed()
        {
            return hasActed;
        }

        void IActable.act()
        {
            hasActed = true;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            NonRealTimeBattleActor otherBattleActorWithSpeed = obj as NonRealTimeBattleActor;
            if (otherBattleActorWithSpeed == null)
                throw new ArgumentException("Object is not a BattleActorWithSpeed");
            if(otherBattleActorWithSpeed.Speed < Speed)
                return -1;
            else if(otherBattleActorWithSpeed.Speed > Speed)
                return 1;
            else 
                return 0;
        }
    }
}
