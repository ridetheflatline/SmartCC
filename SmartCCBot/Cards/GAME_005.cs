using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//The Coin
namespace HREngine.Bots
{
    [Serializable]
public class GAME_005 : Card
    {
		public GAME_005() : base()
        {
            
        }
		
        public GAME_005(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0)
        {
            base.OnPlay(ref board, target,index);
            board.ManaAvailable++;
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
            foreach(Card c in board.Hand)
            {
                if (c.CurrentCost == board.ManaAvailable + 1)
                    return true;
            }

            return false;
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
            return 100;
        }
		
    }
}