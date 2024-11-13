﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Safari
{
    public class Penguin : Bird, IMove
    {
        public Penguin(float weight) : base(weight)
        {
        }

        public void Move()
        {
            Console.WriteLine("Penguin is moving!!!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Penguin is braying?");
        }
    }
}
