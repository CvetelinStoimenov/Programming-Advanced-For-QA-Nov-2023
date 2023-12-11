namespace Raiding.Models.Heroes
{
    internal class Warrior : Fighter
    {
        public Warrior(string name) : base(name)
        {
        }

        public override int Power => 100;
        public override string CastAbility()
        {
            return base.CastAbility();
        }
    }
}
