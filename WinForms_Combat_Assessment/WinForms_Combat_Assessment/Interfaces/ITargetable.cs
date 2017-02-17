namespace WinForms_Combat_Assessment
{
    public interface ITargetable
    {        
        void RecieveWeaponAction(Weapon w, int strModifer);

        void RecieveSpellAction(Spell s, int intModifer);
        
        void RecieveItemAction(Item i);

        void DoWeaponAction(ITargetable target);

        void DoSpellAction(ITargetable target);

        void DoItemAction(ITargetable target);
    }
}