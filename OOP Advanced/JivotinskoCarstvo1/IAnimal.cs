﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JivotinskoCarstvo1
{
    public interface IAnimal : IMakeNoise, IMakeTrick
    {
        void Perform();
    }
}
