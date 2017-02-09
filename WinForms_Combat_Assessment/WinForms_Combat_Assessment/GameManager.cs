using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WinForms_Combat_Assessment
{
    class GameManager
    {
        private List<Character> m_gameRoster;
        private int m_playerCount; 

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
        private GameManager() { m_gameRoster = new List<Character>(); }

        private static readonly GameManager instance = new GameManager();

        public static GameManager Instance
        {
            get
            {                
                return instance;
            }
        }

        public FSM FSM_GAMESTATE
        {
            get; set;
        }

        public void AddToRoster(Character c)
        {
            m_gameRoster.Add(c);
        }
    }
}