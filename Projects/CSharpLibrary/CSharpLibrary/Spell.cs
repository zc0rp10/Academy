using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLibrary
{
    public class Spell
    {
        public Spell(string name, int damage, MagicType magicType)
        {
            Name = name;
            Damage = damage;
            MagicType = magicType;

        }

        public string Name { get; set; }
        public int Damage { get; set; }
        public MagicType MagicType { get; set; }
    }

    public enum MagicType
    {
        Fire,
        Ice,
    }
}
