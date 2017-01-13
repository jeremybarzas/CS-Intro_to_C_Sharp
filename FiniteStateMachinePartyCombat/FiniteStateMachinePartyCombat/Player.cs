namespace FiniteStateMachinePartyCombat
{
    class Player
    {
        private string m_name;

        public delegate void OnPlayerEndTurn();
        public OnPlayerEndTurn onPlayerEndTurn;
        
        public string Name
        {
            get { return m_name; }
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
        }

        public Player()
        {
            m_name = "Default Player Name";
        }

        public Player(string n)
        {
            m_name = n;
        }
    }
}