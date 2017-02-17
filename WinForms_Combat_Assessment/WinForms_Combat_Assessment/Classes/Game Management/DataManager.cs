using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WinForms_Combat_Assessment
{
    public class DataManager
    {
        public FSM FSM { get; set; }

        public Character CurrentPlayer { get; set; }

        public Random DiceRoller { get; set; }

        public List<Character> GameRoster { get; set; }

        public List<Weapon> WeaponList { get; set; }

        public List<Spell> SpellList { get; set; }

        public List<Item> ItemList { get; set; }        

        public List<int> UsedRolls { get; set; }

        public int TurnCount { get; set; }

        public int RemainingPlayers { get; set; }

        public int RoundNumber { get; set; }             

        public int PlayerCount { get; set; }      

        public void AddToRoster(Character c)
        {
            GameRoster.Add(c);
            SetCurrentPlayer();
        }

        public void SetRemainingPlayers()
        {
            RemainingPlayers = 0;

            foreach (Character character in GameRoster)
            {
                if (character.Alive == true)
                    RemainingPlayers += 1;
            }
        }

        public void AssignTurnOrder()
        {
            SetRemainingPlayers();

            DiceRoller = new Random();
            int maxRange = RemainingPlayers + 1;
            int currentRoll;

            foreach (Character character in GameRoster)
            {
                currentRoll = DiceRoller.Next(1, maxRange);

                if (UsedRolls.Contains(currentRoll))
                {
                    while (UsedRolls.Contains(currentRoll))
                    {
                        currentRoll = DiceRoller.Next(1, maxRange);
                        Debug.WriteLine(currentRoll);
                    }
                }

                character.TurnOrder = currentRoll;
                UsedRolls.Add(currentRoll);
            }

            foreach (Character dude in GameRoster)
            {
                Debug.WriteLine(dude.Name + "'s turn order is " + dude.TurnOrder + "\n\n");
            }

            GameRoster.Sort((a, b) => (a.TurnOrder.CompareTo(b.TurnOrder)));
            UsedRolls.Clear();
            TurnCount = 0;
        }

        public void SetCurrentPlayer()
        {
            if (TurnCount == 0)
            {
                CurrentPlayer = GameRoster[0];
                return;
            }
            else
            {
                int i = GameRoster.IndexOf(CurrentPlayer) + 1;

                if (GameRoster[i].Alive == true)
                {
                    CurrentPlayer = GameRoster[i];
                }
                if (i == GameRoster.Count)
                {
                    i = 0;
                }
            }
        }       

        public DataManager()
        {
            FSM = new FSM();                   
            GameRoster = new List<Character>();           
            WeaponList = new List<Weapon>();
            SpellList = new List<Spell>();
            ItemList = new List<Item>();
            UsedRolls = new List<int>();

            RoundNumber = 1;        
        }
    }
}