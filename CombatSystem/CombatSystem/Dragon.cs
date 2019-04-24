using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem
{
    class Dragon : Enemy
    {
        public Dragon(double PlayerLevel)
        {
            EnemyName = "Dragon";
            EnemyLevel = PlayerLevel * 5;
            EnemyMaxHealth = 5 + (PlayerLevel * 5);
            EnemyHealth = EnemyMaxHealth;
            EnemyAttack = 1 + (PlayerLevel * 0.75);
        }
    }
}
