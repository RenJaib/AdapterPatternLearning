﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Interfaces
{
    public interface IDatabaseAccess
    {
        string GetUserInfo(string userId);
    }
}
