using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Bestial Wrath
namespace HREngine.Bots
{
    [Serializable]
public class EX1_549 : Card
    {
		public EX1_549() : base()
        {
            
        }
		
        public EX1_549(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
            TargetTypeOnPlay = TargetType.MINION_FRIEND;
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0,int choice = 0)
        {
            base.OnPlay(ref board, target,index);
            if (target != null)
            {
                if(target.Race == CRace.BEAST)
                {
                    target.IsImmune = true;
                    target.TempAtk += 2;
                }
            }
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
