using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Life Tap
namespace HREngine.Bots
{
    [Serializable]
public class CS2_056 : Card
    {
		public CS2_056() : base()
        {
            
        }
		
        public CS2_056(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0)
        {
            base.OnPlay(ref board, target,index);
            board.FriendCardDraw++;
            board.HeroFriend.CurrentHealth -= 2;
            board.Resimulate();
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
            if (board.HeroFriend.CurrentHealth < 3)
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
            return 10;
        }
		
    }
}
