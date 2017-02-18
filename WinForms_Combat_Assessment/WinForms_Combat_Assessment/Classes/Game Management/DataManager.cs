using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{    
    public class DataManager
    {
        private FSM m_mainFSM;
        private Character m_currentPlayer;        
        private List<Character> m_gameRoster;
        private List<Weapon> m_weaponList;
        private List<Spell> m_spellList;
        private List<Item> m_itemList;
        private int m_turnCount;
        private int m_remainingPlayers;
        private int m_roundNumber;
        private int m_playerCount;

        public FSM MainFSM
        {
            get { return m_mainFSM; }
            set { m_mainFSM = value; }
        }

        public Character CurrentPlayer
        {
            get { return m_currentPlayer; }
        }       

        public List<Character> GameRoster
        {
            get { return m_gameRoster; }
        }

        public List<Weapon> WeaponList
        {
            get { return m_weaponList; }
        }

        public List<Spell> SpellList
        {
            get { return m_spellList; }
        }

        public List<Item> ItemList
        {
            get { return m_itemList; }
        }

        public int TurnCount
        {
            get { return m_turnCount; }
            set { m_turnCount = value; }
        }

        public int RemainingPlayers
        {
            get { return m_remainingPlayers; }
        }

        public int RoundNumber
        {
            get { return m_roundNumber; }
            set { m_roundNumber = value; }
        }

        public int PlayerCount
        {
            get { return m_playerCount; }
            set { m_playerCount = value; }
        }

        public void AddToWeaponList(Weapon weapon)
        {
            WeaponList.Add(weapon);
        }

        public void AddToSpellList(Spell spell)
        {
            SpellList.Add(spell);
        }

        public void AddToItemList(Item item)
        {
            ItemList.Add(item);
        }

        public void AddToRoster(Character c)
        {
            c.AddToWeapons(new Sword("Sword", 25));

            c.AddToSpellbook(new MagicMissle("Magic Missle", 25, 25));
            c.AddToSpellbook(new Flashburn("Flashburn", 25, 25));

            c.AddToBackpack(new Potion("Potion", 50, 0));
            c.AddToBackpack(new Potion("Ether", 0, 50));
            c.AddToBackpack(new Potion("Elixir", 30, 30));
            c.AddToBackpack(new RuneStone("Red Runestone", 1, 0));

            m_gameRoster.Add(c);
        }

        public void SetRemainingPlayers()
        {
            m_remainingPlayers = 0;

            foreach (Character character in m_gameRoster)
            {
                if (character.Info.Alive == true)
                    m_remainingPlayers += 1;
            }
        }

        public void AssignTurnOrder()
        {
            SetRemainingPlayers();

            Random m_diceRoller = new Random();
            int maxRange = m_remainingPlayers + 1;
            int currentRoll;

            foreach (Character character in m_gameRoster)
            {
                List<int> usedRolls = new List<int>();

                currentRoll = m_diceRoller.Next(1, maxRange);

                if (usedRolls.Contains(currentRoll))
                {
                    while (usedRolls.Contains(currentRoll))
                    {
                        currentRoll = m_diceRoller.Next(1, maxRange);
                    }
                }

                character.Info.TurnOrder = currentRoll;
                usedRolls.Add(currentRoll);
            }

            m_gameRoster.Sort((a, b) => (a.Info.TurnOrder.CompareTo(b.Info.TurnOrder)));
            m_turnCount = 0;

            SetCurrentPlayer(0);            
        }

        public void SetCurrentPlayer(int i)
        {
            m_currentPlayer = m_gameRoster[i];           
        }       

        public DataManager()
        {
            MainFSM = new FSM();                   
            m_gameRoster = new List<Character>();           
            m_weaponList = new List<Weapon>();
            m_spellList = new List<Spell>();
            m_itemList = new List<Item>();

            m_roundNumber = 1;        
        }
    }
}