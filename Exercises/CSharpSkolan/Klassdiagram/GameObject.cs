using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Klassdiagram
{
    class GameObject
    {
        public bool IsDead;
        public Vector2 Position;
        public float Radius;
        public Vector2 Speed;
        public float Rotation;

        public bool CollidesWith(IGameObject other)
        {
            return false;
        }
    }

    public interface IGameObject
    {
    }
}
