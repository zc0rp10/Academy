using System;
using System.Collections.Generic;
using System.Text;

namespace NotAnotherRPG
{
    public enum Job
    {
        Fighter,
        Thief,
        Mage,
    }

    class Player : Being
    {
        public Job Job { get; set; }

        public Player(string name, int hp, int strength, int agility, int speed, Job job) : base(name, hp, strength, agility, speed)
        {
            Job = job;
        }

    }
}
