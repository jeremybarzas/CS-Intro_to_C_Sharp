using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;


namespace WinForms_Combat_Assessment
{
    [XmlInclude(typeof(DataManager))]
    public class DataManager
    {
        public int TurnCount
        {
            get; set;
        }

        public int RemainingPlayers
        {
            get; set;
        }

        public int RoundNumber
        {
            get; set;
        }

        public Character CurrentPlayer
        {
            get; set;
        }

        public List<Character> GameRoster
        {
            get; set;
        }

        public int PlayerCount
        {
            get; set;
        }

        public Random DiceRoller
        {
            get; set;
        }

        public List<int> UsedRolls
        {
            get; set;
        }

        
        public FSM FSM
        {
            get; set;
        }

        public void AddToRoster(Character c)
        {
            GameRoster.Add(c);
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
            //FSM = new FSM();
            UsedRolls = new List<int>();
            GameRoster = new List<Character>();            
        }

        public DataManager(DataManager dm)
        {
            TurnCount = dm.TurnCount;
            RemainingPlayers = dm.RemainingPlayers;
            RoundNumber = dm.RoundNumber;
            CurrentPlayer = dm.CurrentPlayer;
            GameRoster = dm.GameRoster;
            PlayerCount = dm.PlayerCount;
            DiceRoller = dm.DiceRoller;
            UsedRolls = dm.UsedRolls;
            //FSM = dm.FSM;
        }
    }
}