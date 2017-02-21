using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public interface ITargetable
    {
        int RecieveWeaponAction(Weapon w, int strModifer);

        List<int> RecieveSpellAction(Spell s, int intModifer);

        List<int> RecieveItemAction(Item i);

        int DoWeaponAction(Character target);

        List<int> DoSpellAction(Character target);

        List<int> DoItemAction(Character target);
    }
}