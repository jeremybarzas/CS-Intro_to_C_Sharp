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

        public bool AddToWeapons(Weapon weapon)
        {
            if (Info.Weapons.Count >= 2)
                return false;

            Info.Weapons.Add(weapon);
            return true;
        }

        public bool AddToSpellbook(Spell spell)
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

            if (this.Info.Health <= 0)
                this.Info.Alive = false;
        }

        public void RecieveSpellAction(Spell s, int modifer)
        {
            s.Cast(this, modifer);

            if (this.Info.Health <= 0)
                this.Info.Alive = false;
        }

        public void RecieveItemAction(Item i)
        {
            i.Use(this);

            if (this.Info.Health <= 0)
                this.Info.Alive = false;
        }

        public void DoWeaponAction(Character target)
        {
            target.RecieveWeaponAction(this.Info.ActiveWeapon, this.Info.Strength);
        }

        public void DoSpellAction(Character target)
        {
            target.RecieveSpellAction(this.Info.ActiveSpell, this.Info.Intellect);
            this.Info.Mana -= this.Info.ActiveSpell.ManaCost;
        }

        public void DoItemAction(Character target)
        {
            target.RecieveItemAction(this.Info.ActiveItem);
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

        public Character(string n, Weapon w1, Weapon w2, Spell s1, Spell s2, Item i1, Item i2, Item i3, Item i4)
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

            AddToWeapons(w1);
            AddToWeapons(w2);

            AddToSpellbook(s1);
            AddToSpellbook(s2);

            AddToBackpack(i1);
            AddToBackpack(i2);
            AddToBackpack(i3);
            AddToBackpack(i4);
        }
    }
}

//public void CommitAction(int strModifer, int intModifer, params ITargetable[] targets)