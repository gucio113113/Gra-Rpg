using ConsoleApp1.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{

	public abstract class Character
	{
		

	private int _health;
	public string Name { get; set; }
	public int MaxHealth { get; set; }

	public double DodgeChance { get; set; }

	public double CritChance { get; set; }

	public List<BattleAction> Actions = new List<BattleAction>();




	public int Health { 
		get => _health;
		private set => _health = Math.Clamp(value, 0, MaxHealth);
	
	}
	public bool IsAlive => Health > 0;

		protected Character(string name, int maxHealth,double DodgeChance,double CritChance )
		{
			if(string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Postać musi miec nazwę", nameof(name));
			}

			if(maxHealth <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(maxHealth));
			}
			Name = name;
			MaxHealth = maxHealth;
			Health = maxHealth;
			this.DodgeChance = DodgeChance;
			this.CritChance = CritChance;

		}

		public void TakeDamage(int amount)
		{
			if(amount <= 0 )
			{
				throw new ArgumentOutOfRangeException(nameof(amount));
			}

			Health -= amount;
			Console.WriteLine($"{Name} otrzymuje {amount} obrażeń (HP: {Health}/{MaxHealth})");

			if(!IsAlive)
			{
				Console.WriteLine($"{Name} trafia do błota...");
			}


		}

		public abstract void BasicAttack(Character target);
		public override string ToString() => $"{GetType().Name} {Name} [HP: {Health}/{MaxHealth}]";

		public abstract string ExtraInfo();


	}
}
