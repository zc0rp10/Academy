using System;
using System.Collections.Generic;
using System.Text;

namespace Klassdiagram
{
    class Meteor : GameObject
    {
        public MeteorType Type;
        public float ExplosionScale;

        public void Meter(MeteorType type)
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public static IEnumerable<Meteor> BreakMeteor(Meteor meteor)
        {
            
        }

    }

    public class MeteorType
    {
    }

    public class GameTime
    {
    }
}
