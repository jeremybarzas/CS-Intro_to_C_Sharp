using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    public interface ICastable
    {
        void Cast(Character target, int Int);
    }
}