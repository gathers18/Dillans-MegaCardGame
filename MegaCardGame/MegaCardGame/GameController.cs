using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class GameController
    {
        private NonPlayerCharacter enemy = new NonPlayerCharacter();
        private PlayerCharacter player = new PlayerCharacter();
        


        public void Battle()
        {
            player.MaxHealthPoints = 50;
            player.BaseDamage = 10;
            player.CharacterName = "Your Character";
        }
        
        public NonPlayerCharacter EnemyFinder(int enemyType)
        {



            /*
            if (enemyType == 1)
            {
                Warlock warlock = new Warlock(); 
                return warlock;
            }
            else if (enemyType == 2)
            {
                Bandit bandit = new Bandit();
                return bandit;
            }
            else
            {
                Scoundrel scoundrel = new Scoundrel();
                return scoundrel;
            }
            */
        }
        
        public void PickClass()
        {
            
        }
    }
}
