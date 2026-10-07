using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp1.Characters.Character;

namespace ConsoleApp1.Characters
{
	internal class Archer : Character
    {
	public int ArrowDamage { get; set; }

	public int NumberOfPoisonArrows { get; set; }
	public Archer(string name, int maxHealth, int arrowDamage,int NumberOfPoisonArrows, double DodgeChance, double CritChance) : base(name, maxHealth,DodgeChance,CritChance)
	{
		ArrowDamage = arrowDamage;
		this.NumberOfPoisonArrows = NumberOfPoisonArrows;
		this.DodgeChance= DodgeChance;
			this.CritChance = CritChance;

	}

		public override void BasicAttack(Character target)
		{
			Console.WriteLine($"{Name} strzela dwukrotnie do bezbronnego {target.Name}!");
			target.TakeDamage(ArrowDamage);
			target.TakeDamage(ArrowDamage);
		}
		public void UsePoisonArrow(Character target)
		{
			if (NumberOfPoisonArrows == 0)
			{
				throw new InvalidOperationException("Brak zatrutych strzal");
			}
			NumberOfPoisonArrows--;
		}
		public override string ExtraInfo()
		{
			return "";
		}



    }
}
