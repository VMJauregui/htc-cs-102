using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem
{
    class Golem : Enemy
    {
        public Golem(double PlayerLevel)
        {
            EnemyName = "Golem";
            EnemyLevel = PlayerLevel * 4;
            EnemyMaxHealth = 5 + (PlayerLevel * 5);
            EnemyHealth = EnemyMaxHealth;
            EnemyAttack = 1 + (PlayerLevel * 0.5);
        }
    }
}
