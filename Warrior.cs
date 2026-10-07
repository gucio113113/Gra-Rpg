using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp1.Characters.Character;

namespace ConsoleApp1.Characters
{
	internal class Warrior : Character
    {
	public int Strength {  get; set; }
	

	public Warrior(string name, int maxHealth, int strength,double DodgeChance,double CritChance) : base(name, maxHealth,DodgeChance,CritChance)
	{
		Strength = strength;
			this.CritChance=CritChance;
			this.DodgeChance = DodgeChance;

	}

		public override void BasicAttack(Character target)
		{
			Console.WriteLine($"{Name} bezcześci {target.Name}!");
			target.TakeDamage(Strength);
		}
        public override string ExtraInfo()
        {
            return "";
        }

    }
}
