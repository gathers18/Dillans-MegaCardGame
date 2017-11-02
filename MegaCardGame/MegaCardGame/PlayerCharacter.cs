using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    class PlayerCharacter : Character
    {
        private /*char*/ string characterName;
        //cant use 
        private NormalAttack normalAttack;
        private SpecialAttack specialAttack;

        public string CharacterName
        {
            get
            {
                return characterName;
            }
            set
            {
                characterName = value;
            }
        }
        public NormalAttack NormalAttacK
        {
            get
            {
                return normalAttack;
            }
            set
            {
                normalAttack = value;
            }
        }
        public SpecialAttack SpecialAttacK
        {
            get
            {
                return specialAttack;
            }
            set
            {
                specialAttack = value;
            }
        }
    }
}
