using System;

namespace WinForms_Combat_Assessment
{
    public interface IConsumable
    {
        void Consume(Character target);
    }
}