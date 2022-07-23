using BattleSystem.OrderSelectors_concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class Battle
    {
        public IEnumerable<IActable> BattleActors { get; set; }
        private IOrderSelecter OrderSelector { get; set; }
        private bool IsEnded { get; set; } = false;

        public Battle(IEnumerable<IActable> battleActors, TimeSystem timeSystem)
        {
            this.BattleActors = battleActors;
            switch(timeSystem)
            {
                case TimeSystem.RealTime:
                    OrderSelector = new RealTimeSelector();
                    break;
                case TimeSystem.NonRealTime:
                    if (BattleActors is ICollection<IComparable>)
                        OrderSelector = new NonRealTimeSelector(battleActors as ICollection<IComparable>);
                    else
                        throw new ArgumentException("Actor List is now ICollection<IComparable>");
                    break;
                default:
                    throw new ArgumentException("There is no" + timeSystem.ToString());
            }
        }

        public void StartBattle()
        {
            while (checkEnded())
            {
                OrderSelector.getCurrentTurnActor().act(); //더 구현하면 Action타입 반환 예정
                //Action의 결과 반영
                
            }
        }

        private bool checkEnded()
        {
            return false;
        }
    }
}