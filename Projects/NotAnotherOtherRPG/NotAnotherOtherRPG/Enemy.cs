using System;
using System.Collections.Generic;
using System.Text;

namespace NotAnotherOtherRPG
{
    class Enemy : Being
    {
        public Enemy(string name, int hp, int strength, int agility, int speed, EnemyType enemyType) : base(name, hp, strength, agility, speed)
        {

        }
    }

    enum EnemyType
    {
        Goblin,
        Skeleton,
    }
}
