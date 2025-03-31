using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IFamilyDetailsService
    {

      Task<IEnumerable<FamilyDetails>> GetListOfFamilyDetailsAsync();
      Task<FamilyDetails> GetFamilyDetailsByIdAsync(int id);
      Task<FamilyDetails> AddFamilyDetailsAsync(FamilyDetails familyDetails);
      Task<FamilyDetails> DeleteFamilyDetailsAsync(int id);
      Task<FamilyDetails> UpdateFamilyDetailsAsync(int id, FamilyDetails FamilyDetails);
    }
}
