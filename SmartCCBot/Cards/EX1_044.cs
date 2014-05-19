using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Questing Adventurer
namespace HREngine.Bots
{
    [Serializable]
public class EX1_044 : Card
    {
		public EX1_044() : base()
        {
            
        }
		
        public EX1_044(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0)
        {
            base.OnPlay(ref board, target,index);
        }

        public override void OnDeath(ref Board board)
        {
            base.OnDeath(ref board);
        }

        public override void OnPlayOtherMinion(ref Board board, Card Minion)
        {
            base.OnPlayOtherMinion(ref board, Minion);
            board.GetCard(Id).AddBuff(new Buff(1, 1, Id));
        }

        public override void OnCastSpell(ref Board board, Card Spell)
        {
		    base.OnCastSpell(ref board, Spell);
            if(IsFriend)
            {
                board.GetCard(Id).AddBuff(new Buff(1, 1, Id));

            }

        }
		
		public override bool ShouldBePlayed(Board board)
        {
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
