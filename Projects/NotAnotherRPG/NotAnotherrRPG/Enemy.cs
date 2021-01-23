using System;
using System.Collections.Generic;
using System.Text;

namespace NotAnotherRPG
{
    enum EnemyType
    {
        Goblin,
        Skeleton,
    }

    class Enemy : Being
    {
        public Enemy(string name, int hp, int strength, int agility, int speed, EnemyType enemyType) : base(name, hp, strength, agility, speed)
        {

        }
    }
}
