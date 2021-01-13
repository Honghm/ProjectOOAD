using MultiCardSystem.Data.Entities;
using MultiCardSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Services
{
   public class CardService
    {
        private readonly ICardRepository _CardRepository;
        public CardService()
        {
            _CardRepository = new CardRepository(new Data.EF.MultiCardDbContext());
        }
        public CardService(ICardRepository cardRepository)
        {
            _CardRepository = cardRepository;
        }

        public async Task<bool> Delete(string id)
        {
            return await _CardRepository.Delete(id);
        }
        public List<Card> GetAllCards()
        {
            return _CardRepository.GetAllCards();
        }
        public async Task<Card> GetCardById(string id)
        {
            return await _CardRepository.GetCardById(id);
        }

        public async Task<bool> Insert(Card request)
        {
            return await _CardRepository.Insert(request);
        }
        public async Task<bool> Update(string id, string OldPIN, string NewPIN)
        {
            return await _CardRepository.Update(id,OldPIN,NewPIN);
        }
    }
}
