﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_L_O_B_O
{
    class Idle:IStrategy
    {
        Animator animator;

        public Idle()
        {
            this.animator = animator;
        }

        public void Execute(DIRECTION direction)
        {
            throw new NotImplementedException();
        }
    }
}