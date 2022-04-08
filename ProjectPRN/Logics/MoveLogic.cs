using ProjectPRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.Logics
{
    internal class MoveLogic
    {
        public List<Move> GetAllMoves()
        {
            using(var context= new PokedexContext())
            {
                context.Types.ToList();
                return context.Moves.ToList(); 
            }
        }
        public Move GetMoveById(int id)
        {
            using(var context = new PokedexContext())
            {
                return context.Moves.FirstOrDefault(x => x.MoveId == id);
            }
        }
        public void DeleteMoveById(int id)
        {
            using(var context = new PokedexContext())
            {
                Move move = context.Moves.FirstOrDefault(x => x.MoveId == id);
                context.Moves.Remove(move);
                context.SaveChanges();
            }
        }
        public void AddMove(Move move)
        {
            using(var context = new PokedexContext())
            {
                context.Moves.Add(move);
                context.SaveChanges();
            }
        }

        public void EditMove(Move move)
        {
            using(var context = new PokedexContext())
            {
                Move curMove =  context.Moves.FirstOrDefault(x => x.MoveId == move.MoveId);
                curMove.MoveName = move.MoveName;
                curMove.TypeId = move.TypeId;
                curMove.MoveCat = move.MoveCat;
                curMove.MovePower = move.MovePower;
                curMove.Pp = move.Pp;
                context.SaveChanges();
            }
        }
    }
}
