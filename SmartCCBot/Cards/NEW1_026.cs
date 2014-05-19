using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Violet Teacher
namespace HREngine.Bots
{
    [Serializable]
public class NEW1_026 : Card
    {
		public NEW1_026() : base()
        {
            
        }
		
        public NEW1_026(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
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
        }

        public override void OnCastSpell(ref Board board, Card Spell)
        {
		    base.OnCastSpell(ref board, Spell);
            if(IsFriend)
            {
                if(board.MinionFriend.Count < 7)
                {
                    board.AddCardToBoard("NEW1_026t", true);

                }
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
