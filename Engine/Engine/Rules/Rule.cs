﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Rules
{

    public interface IRule
    {
        Message process(Message message);
    }


}
