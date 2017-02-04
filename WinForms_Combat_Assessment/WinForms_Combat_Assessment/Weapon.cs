namespace WinForms_Combat_Assessment
{
    public class Weapon : ISwingable
    {
        private string m_name;
        private int m_damage;

        public Weapon(string n, int dmg)
        {
            m_name = n;
            m_damage = dmg;
        }

        public void Swing(Character target, int Str)
        {
            target.Health -= (m_damage * Str); 
        }
    }
}