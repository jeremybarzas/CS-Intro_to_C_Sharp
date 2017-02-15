namespace WinForms_Combat_Assessment
{
    public class Sword : ISwingable
    {
        private string m_name;
        private int m_damage;

        public Sword(int dmg)
        {
            m_name = "Sword";
            m_damage = dmg;
        }

        public void Swing(Character target, int Str)
        {
            target.Health -= (m_damage * Str); 
        }
    }
}