namespace WinForms_Combat_Assessment
{
    public interface ITargetable
    {        
        void RecieveWaponAction(Weapon w, int strModifer);

        void RecieveSpellAction(Spell s, int intModifer);
        
        void RecieveItemAction(Item i);

        void CommitAction(ITargetable weaponTarget, ITargetable spellTarget, ITargetable itemTarget, int strModifer, int intModifer);
    }
}