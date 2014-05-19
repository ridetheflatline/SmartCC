using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Lightwarden
namespace HREngine.Bots
{
    [Serializable]
public class EX1_001 : Card
    {
		public EX1_001() : base()
        {
            
        }
		
        public EX1_001(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
        }

        public override void OnOtherMinionHeal()
        {
            base.OnOtherMinionHeal();
            AddBuff(new Buff(2, 0, Id));
        }
        public override void OnPlay(ref Board board, Card target = null,int index = 0)
        {
            base.OnPlay(ref board, target,index);
        }

        public override void OnDeath(ref Board board)
        {
            base.OnDeath(ref board);
            board.FriendCardDraw++;
            board.Resimulate();
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
