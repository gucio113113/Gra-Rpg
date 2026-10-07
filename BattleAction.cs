using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using ConsoleApp1.Characters;
using ConsoleApp1;

namespace ConsoleApp1.Actions
{
    public enum TargetType { Enemy, Ally,Self}
    public record ActionChoice(BattleAction Action, Character Target);
    public abstract class BattleAction
    {
        public abstract string Name { get; }

        public abstract TargetType Target { get; }

        public virtual bool CanUse(Character user) => true;

        public abstract void Execute(Character user, Character target, BattleAction battle);

        public static bool DealDamage(Character user, Character target,int basedamage,Battle battle)
        {
            if (battle.random.NextDouble() < target.DodgeChance)
            {
                return false;
            }
             double spread = 0.8 + battle.random.NextDouble() * 0.4;
            int damage = (int)spread * basedamage;
            if(0.00 + battle.random.NextDouble() * 1> user.CritChance)
            {
                Console.WriteLine("Trafienie Krytyczne \n");
                target.TakeDamage(damage*3);
                return true;
            }
            else
            {
                target.TakeDamage(damage);
                return true;
            }
            
        }

    }
}
