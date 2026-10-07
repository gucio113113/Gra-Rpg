using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp1.Characters.Character;

namespace ConsoleApp1.Characters
{
	internal class Mage : Character
    {
		public int SpellPower { get; set; }
		public int MeleeDamage { get; set; }
		public int Mana { get; private set; }
		private const int StaffPower = 3;

		private const int SpellCost = 20;


		public Mage(string name, int maxHealth, int spellPower, int mana,double DodgeChance, double CritChance) : base(name, maxHealth,DodgeChance,CritChance)
		{
			SpellPower = spellPower;
			Mana = mana;
			this.DodgeChance = DodgeChance;
			this.CritChance = CritChance;
		}

		public override void BasicAttack(Character target)
		{
			if (Mana >= SpellCost)
			{
				Mana -= SpellCost;
				Console.WriteLine($"{Name} uzywa mocy świata podziemii atakując wiązką światła w {target.Name}!!! [Mana: {Mana}]");
				target.TakeDamage(SpellPower);
			}
			else
			{
				Console.WriteLine($"{Name} nie ma many wię atakuje kosturem");
				target.TakeDamage(StaffPower);
			}
		}
        public override string ExtraInfo()
        {
            return "";
        }


    }

	}
