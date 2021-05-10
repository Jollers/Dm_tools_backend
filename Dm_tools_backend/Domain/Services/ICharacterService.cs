using Dm_tools_backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dm_tools_backend.Domain.Services
{
    public interface ICharacterService
    {
        Task<Character> CreateCharacterAsync(string name, string description, int age);
        Task<IEnumerable<Character>> GetCharactersById(int id);
        Task<IEnumerable<Character>> GetCharactersAsync();
        Task<bool> DeleteCharacterAsync(int id);
        Task<IEnumerable<Character>> UpdateCharacterById(int id);
    }
}
