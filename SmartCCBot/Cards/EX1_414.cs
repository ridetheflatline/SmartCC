using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Grommash Hellscream
namespace HREngine.Bots
{
    [Serializable]
public class EX1_414 : Card
    {
        public EX1_414()
            : base()
        {

        }

        public EX1_414(CardTemplate newTemplate, bool isFriend, int id)
            : base(newTemplate, isFriend, id)
        {

        }

        public override void Init()
        {
            base.Init();
            IsCharge = true;
            HasEnrage = true;
        }

        public override void OnEnrage(bool enraged, ref Board board)
        {
            if (enraged)
            {
                currentAtk += 6;
            }
            else
            {
                currentAtk -= 6;
            }
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0,int choice = 0)
        {
            base.OnPlay(ref board, target, index);
        }

        public override void OnDeath(ref Board board)
        {
            base.OnDeath(ref board);
        }

        public override void OnPlayOtherMinion(ref Board board, Card Minion)
        {
            base.OnPlayOtherMinion(ref board, Minion);
        }

        public override void OnCastSpell(ref Board board, Card Spell)
        {
            base.OnCastSpell(ref board, Spell);
        }


    }
}
