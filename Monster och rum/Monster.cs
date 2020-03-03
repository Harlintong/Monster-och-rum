using System;
using System.Collections.Generic;
using System.Text;

namespace Monster_och_rum
{
    class Monster
    {
        List<int> Damage = new List<int>();
        Random Generator = new Random();

        private int hitpoints;
        private int xp;

        public Monster()
        {
            hitpoints = 100;

        }

        public void Hurt(int x)
        {
            hitpoints = hitpoints - x;
        }

        public void Attack(int x)
        {
            x = x - ; 
        }

        public bool IsAlive()
        {
            if(hitpoints <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
