﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Rules
{
    public interface IBlockingRule
    {
        bool will_allow(Message message);
    }
}
