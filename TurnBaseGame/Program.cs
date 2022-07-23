using BattleSystem;
using BattleSystem.OrderSelectors_concrete;
using System;
using System.Collections.Generic;

namespace TurnBaseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var battleActorWithSpeeds = new List<IComparable>();

            battleActorWithSpeeds.Add(new NonRealTimeBattleActor(2));
            battleActorWithSpeeds.Add(new NonRealTimeBattleActor(1));
            battleActorWithSpeeds.Add(new NonRealTimeBattleActor(4));
            battleActorWithSpeeds.Add(new NonRealTimeBattleActor(3));
            battleActorWithSpeeds.Add(new NonRealTimeBattleActor(5));

            var nonRealTimeOrderBySpeed = new NonRealTimeSelector(battleActorWithSpeeds);

            Battle battle = new Battle(battleActorWithSpeeds as IEnumerable<IActable>, TimeSystem.NonRealTime);

            nonRealTimeOrderBySpeed.AddActor(new NonRealTimeBattleActor(7));

            for (int i = 0; i < nonRealTimeOrderBySpeed.GetCountOfActor(); i++)
            {
                NonRealTimeBattleActor temp = nonRealTimeOrderBySpeed.getCurrentTurnActor() as NonRealTimeBattleActor;
                Console.WriteLine(temp.Speed);
                (temp as IActable).act();
            }
        }
    }
}
