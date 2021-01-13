using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
   public interface ICardRepository
    {
        Task<Card> GetCardById(string id);
        List<Card> GetAllCards();
        Task<bool> Insert(Card request);
        Task<bool> Delete(string id);
        Task<bool> Update(string id,string OldPIN,string NewPIN);
        
    }
}
