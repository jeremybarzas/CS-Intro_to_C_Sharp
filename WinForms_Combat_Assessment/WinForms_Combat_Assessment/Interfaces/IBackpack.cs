﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    public interface IBackpack
    {
        void Add(IPackable p);

        void Remove(IPackable p);
    }
}