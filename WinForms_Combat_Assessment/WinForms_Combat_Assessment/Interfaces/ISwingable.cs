using System;
using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public interface ISwingable
    {
        void Swing(Character target, int Str);
    }
}