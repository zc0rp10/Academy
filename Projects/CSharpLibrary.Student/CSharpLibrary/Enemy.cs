using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLibrary
{
    public class Enemy
    {
        public Enemy(int health)
        {
            Health = health;
        }

        public int Health { get; set; }
    }
}
