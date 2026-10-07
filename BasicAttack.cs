using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Actions
{
    public class BasicAttack 
    {
        private readonly string _name;
        private readonly int _damage;

        public BasicAttack(string name,int damage)
        {
            this._name = name;
            this._damage = damage;
        }



    }
}
