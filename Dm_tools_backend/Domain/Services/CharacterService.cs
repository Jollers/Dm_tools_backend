using Dm_tools_backend.Data;
using Dm_tools_backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dm_tools_backend.Domain.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly Dm_toolsDbContext _context;

        public CharacterService(Dm_toolsDbContext _context)
        {
            this._context = _context;
        }

        public async Task<Character> CreateCharacterAsync(string name, string description, int age)
        {
            var character = new Character()
            {
                Name = name,
                Description = description,
                Age = age
            };

            _context.Characters.Add(character);
            await _context.SaveChangesAsync();
            return character;
        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            var character = _context.Characters.FirstOrDefault(x => x.Id == id);

            if(character == null)
            {
                return await Task.FromResult(false);
            }

            _context.Characters.Remove(character);
            int recordsAffecter = await _context.SaveChangesAsync();

            return recordsAffecter > 0;
        }

        public async Task<IEnumerable<Character>> GetCharactersAsync()
        {
            return await _context.Characters.ToListAsync();
        }

        public async Task<IEnumerable<Character>> GetCharactersById(int id)
        {
            var character = await _context.Characters.Where(x => x.Id == id).ToListAsync();

            return character;
        }

        public async Task<IEnumerable<Character>> UpdateCharacterById(int id)
        {
            return null;
        }
    }
}
