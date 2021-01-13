using MultiCardSystem.Data.EF;
using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
    public class CardRepository : ICardRepository
    {
        private readonly MultiCardDbContext _context;
        public CardRepository()
        {
            _context = new MultiCardDbContext();
        }
        public CardRepository(MultiCardDbContext Context)
        {
            _context = Context;
        }
        public async Task<bool> Delete(string id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null) return false;
            _context.Cards.Remove(card);
            return await _context.SaveChangesAsync() > 0;
        }

        public List<Card> GetAllCards()
        {
            //var query = from c in _context.Cards
            //            select c;
            //var data = query
            //    .Select(x => new Card()
            //    {
            //        IDCard = x.IDCard,
            //        DateCreated = x.DateCreated,
            //        PINCode = x.PINCode,

            //    }).ToList();
            //return data;
            return _context.Cards.ToList();
        }

        

        public async Task<Card> GetCardById(string id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null) return null;
            return card;
        }

        public async Task<bool> Insert(Card request)
        {
            var card = new Card()
            {
                ID = request.ID,
                IDCard = request.IDCard,
                DateCreated = request.DateCreated,
                PINCode = request.PINCode,
            };
            _context.Cards.Add(card);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(string id,string OldPIN,string NewPIN)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null) return false;
            if (card.PINCode == OldPIN)
            {
                if (!string.IsNullOrEmpty(NewPIN))
                    card.PINCode = NewPIN;
            }
            else
            {
                return false;
            }
           
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
