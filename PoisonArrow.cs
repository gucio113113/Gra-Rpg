using System;
using System.Collections.Generic;
using System.Text;

using ConsoleApp1.Actions;

namespace ConsoleApp1.Actions
{
    class PoisonArrow : BattleAction
    {

        private readonly Archer _archer;

        public PoisonArrow(Archer archer) => archer = _archer;

        public override string Name => $"Zatruta Strzala (zostala {_archer})"





    }
}
