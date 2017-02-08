using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WinForms_Combat_Assessment
{
    class GameManager
    {
        private List<Character> m_gameRoster;

        public List<Character> GameRoster
        {
            get; set;
        }
        private GameManager() { }

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