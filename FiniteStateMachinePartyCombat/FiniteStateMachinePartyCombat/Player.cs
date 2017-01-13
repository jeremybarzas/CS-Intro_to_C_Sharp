using System;

namespace FiniteStateMachinePartyCombat
{
    class Player
    {
        private string m_name;
        private int m_health;
        private bool m_alive;
        public delegate void OnPlayerChange();
        public OnPlayerChange onPlayerEndTurn;
        

        public string Name
        {
            get { return m_name; }
        }

        public int Health
        {
            get { return m_health; }
        }

        public bool Alive
        {
            get { return m_alive; }
        }

        public void Attack()
        {
            
        }

        public void Defend()
        {
            
        }

        public void EndTurn()
        {
            onPlayerEndTurn.Invoke();
           // run and tel that party to get the next dude.
        }

        public Player()
        {
            m_name = "Default Player Name";
            m_health = 100;
            m_alive = true;
        }

        public Player(string n)
        {
            m_name = n;
            m_health = 100;
            m_alive = true;
            onPlayerEndTurn = new OnPlayerChange(doit);
        }
        void doit() { }
    }
}