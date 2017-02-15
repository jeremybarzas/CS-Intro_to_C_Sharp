using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WinForms_Combat_Assessment
{
    class GameManager
    {
        private List<Character> m_gameRoster;
        private int m_playerCount;
        private Random diceRoller;
        private List<int> m_usedRolls;       

        public int TurnCount
        {
            get;
            set;
        }

        public int RemainingPlayers
        {
            get;
            set;
        }
        
        public int RoundNumber
        {
            get;
            set;
        }  
        
        public Character CurrentPlayer
        {
            get;
            set;
        }     

        public List<Character> GameRoster
        {
            get {return m_gameRoster; }
            set { m_gameRoster = value; }
        }

        public int PlayerCount
        {
            get { return m_playerCount; }
            set { m_playerCount = value; }
        }
      
        public Random DiceRoller
        {
            get { return diceRoller; }
            set { diceRoller= value; }
        }

        public List<int> UsedRolls
        {
            get { return m_usedRolls; }
            set { m_usedRolls = value; }
        }

        public FSM FSM
        {
            get; set;
        }

        public void AddToRoster(Character c)
        {
            m_gameRoster.Add(c);
        }

        public void SetRemainingPlayers()
        {
            RemainingPlayers = 0;

            foreach (Character character in m_gameRoster)
            {
                if (character.Alive == true)
                    RemainingPlayers += 1;
            }
        }

        public void AssignTurnOrder()
        {
            SetRemainingPlayers();

            diceRoller = new Random();
            int maxRange = RemainingPlayers + 1;
            int currentRoll;

            foreach (Character character in m_gameRoster)
            {
                currentRoll = diceRoller.Next(1, maxRange);

                if (m_usedRolls.Contains(currentRoll))
                {
                    while (m_usedRolls.Contains(currentRoll))
                    {
                        currentRoll = diceRoller.Next(1, maxRange);
                        Debug.WriteLine(currentRoll);
                    }
                }

                character.TurnOrder = currentRoll;
                m_usedRolls.Add(currentRoll);
            }

            foreach (Character dude in m_gameRoster)
            {
                Debug.WriteLine(dude.Name + "'s turn order is " + dude.TurnOrder + "\n\n");
            }

            m_gameRoster.Sort((a, b) => (a.TurnOrder.CompareTo(b.TurnOrder)));
            m_usedRolls.Clear();
            TurnCount = 0;
        }

        public void SetCurrentPlayer()
        {
            if (TurnCount == 0)
            {
                CurrentPlayer = m_gameRoster[0];
                return;
            }
            else
            {
                int i = m_gameRoster.IndexOf(CurrentPlayer) + 1;

                if (m_gameRoster[i].Alive == true)
                {
                    CurrentPlayer = m_gameRoster[i];                    
                }
                if (i == m_gameRoster.Count)
                {
                    i = 0;
                }
            }                  
        }

        private GameManager()
        {
            m_gameRoster = new List<Character>();
            m_usedRolls = new List<int>();
            RoundNumber = 1;
        }

        private static readonly GameManager instance = new GameManager();

        public static GameManager Instance
        {
            get
            {
                return instance;
            }
        }
    }
}