﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces
{
    public interface ISoldier
    {
         int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }

    }
}
