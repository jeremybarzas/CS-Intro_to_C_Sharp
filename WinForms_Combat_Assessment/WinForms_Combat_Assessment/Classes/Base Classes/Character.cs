using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{
    public class Character : ITargetable
    {
        private Stats m_info;

        public Stats Info
        {
            get { return m_info; }
            set { m_info = value; }
        }

        public bool AddToSpellBook(Spell spell)
        {
            if (Info.Spellbook.Count >= 2)
                return false;

            Info.Spellbook.Add(spell);
                return true;
        }

        public bool AddToBackpack(Item item)
        {
            if (Info.Backpack.Count >= 4)
                return false;

            Info.Backpack.Add(item);
                return true;
        }

        public void RemoveToBackpack(Item item)
        {
            Info.Backpack.Remove(item);
        }

        public void RecieveWeaponAction(Weapon w, int modifer)
        {
            w.Strike(this, modifer);
        }

        public void RecieveSpellAction(Spell s, int modifer)
        {
            s.Cast(this, modifer);
        }

        public void RecieveItemAction(Item i)
        {
            i.Use(this);
        }        

        public void DoWeaponAction(ITargetable target)
        {
            target.RecieveWeaponAction(Info.ActiveWeapon, Info.Strength);
        }

        public void DoSpellAction(ITargetable target)
        {
            target.RecieveSpellAction(Info.ActiveSpell, Info.Intellect);
        }

        public void DoItemAction(ITargetable target)
        {
            target.RecieveItemAction(Info.ActiveItem);   
        }

        public Character() { }

        public Character(string n)
        {
            m_info = new Stats();

            Info.Name = n;
            Info.Health = 100;
            Info.Mana = 100;
            Info.Strength = 1;
            Info.Intellect = 1;
            Info.Alive = true;
            Info.Kills = 0;
            Info.Gold = 0;
            Info.TurnOrder = 0;
        }       
    }
}

//public void CommitAction(int strModifer, int intModifer, params ITargetable[] targets)