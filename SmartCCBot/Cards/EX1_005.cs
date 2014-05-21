using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Big Game Hunter
namespace HREngine.Bots
{
    [Serializable]
public class EX1_005 : Card
    {
		public EX1_005() : base()
        {
            
        }
		
        public EX1_005(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
            TargetTypeOnPlay = TargetType.MINION_Enemy;
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0)
        {
            base.OnPlay(ref board, target,index);
            if(target != null)
            {
                if(target.CurrentAtk >= 7)
                {
                    board.RemoveCardFromBoard(target.Id);
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
		
		public override bool ShouldBePlayed(Board board)
        {
            foreach(Card c in board.MinionEnemy)
            {
                if (c.CurrentAtk >= 7)
                    return true;
            }

            if (board.Hand.Count > 1)
                return false;

            return true;

        }

        public override bool ShouldAttack(Board board)
        {
            return true;
        }

        public override int GetPriorityAttack(ref Board board)
        {
            return 1;
        }

        public override int GetPriorityPlay()
        {
            return 1;
        }
		
    }
}
