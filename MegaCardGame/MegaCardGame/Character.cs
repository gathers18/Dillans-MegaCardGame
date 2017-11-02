using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    public class Character
    {
        int baseDamage;
        int currentHealthPoints;
        int maxHealthPoints;

        public int BaseDamage
        {
            get
            {
                return baseDamage;
            }
            set
            {
                baseDamage = value;
            }
        }

        public int CurrentHealthPoints
        {
            get
            {
                return currentHealthPoints;
            }
            set
            {
                currentHealthPoints = value;
            }
        }

        public int MaxHealthPoints
        {
            get
            {
                return maxHealthPoints;
            }
            set
            {
                maxHealthPoints = value;
            }
        }
    }
}
