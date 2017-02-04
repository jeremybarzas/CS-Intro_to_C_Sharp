using System;
using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    class GameManager
    {
        public int score = 0;
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
            get;set;
        }

        public void AddToRoster(Character c)
        {
            m_gameRoster.Add(c);
        }

        public void IncrementScore()
        {
            score++;
        }
    }
}