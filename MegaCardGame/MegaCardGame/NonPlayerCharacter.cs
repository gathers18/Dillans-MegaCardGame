using MegaCardGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    public class NonPlayerCharacter : Character
    {
        private NormalAttack attack;
        private NonPlayerCharacter enemyType;

        public NormalAttack Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }

        public NonPlayerCharacter EnemyType()
        {

            public int Warlock = 0;
            public int Bandit = 1;
            public int Scoundrel = 2;

            Random rnd = new Random();

            int enemyType = rnd.Next(0, 2);
            return GetEnemyType;
        }
    }
}
            //Random random = new Random;    
                //int randomNumber = random.Next(0,2);

        //make method for random choice for enemyType