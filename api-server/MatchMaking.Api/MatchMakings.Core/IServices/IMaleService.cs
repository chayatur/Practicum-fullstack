using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IMaleService
    {
         Task<IEnumerable<Male>> GetListOfMaleAsync();
         Task<Male> GetMaleByIdAsync(int id);
         Task<Male> AddMaleAsync(Male male);
         Task<Male> DeleteMaleAsync(int id);
         Task<Male> UpdateMaleAsync(int id, Male male);
    }
}
