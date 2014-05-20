using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Totemic Call
namespace HREngine.Bots
{
    [Serializable]
public class CS2_049 : Card
    {
		public CS2_049() : base()
        {
            
        }
		
        public CS2_049(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0)
        {
            base.OnPlay(ref board, target,index);
            board.AddCardToBoard("CS2_052", true);
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
            if (board.MinionFriend.Count > 6)
                return false;

            bool hasHealTotem = false;
            bool hasIncenTotem = false;
            bool hasSpellTotem = false;
            bool hasTauntTotem = false;

            foreach(Card c in board.MinionFriend)
            {
                if (c.template.Id == "CS2_052")
                    hasSpellTotem = true;
                if (c.template.Id == "CS2_051")
                    hasTauntTotem = true;
                if (c.template.Id == "NEW1_009")
                    hasHealTotem = true;
                if (c.template.Id == "CS2_050")
                    hasIncenTotem = true;
            }


            if (hasHealTotem && hasIncenTotem && hasSpellTotem && hasTauntTotem)
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