using Dm_tools_backend.Domain.Entities;
using Dm_tools_backend.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dm_tools_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly ICharacterService characterService;

        public CharactersController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }

        // GET: api/<CharacterController>
        [HttpGet("all")]
        public async Task<ActionResult<Character>> GetCharactersAsync()
        {
            var getCharacter = await characterService.GetCharactersAsync();

            return Ok(getCharacter);
        }

        // GET api/<CharacterController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharactersById(int id)
        {
            var getCharacter = await characterService.GetCharactersById(id);

            if(!getCharacter.Any())
            {
                string characterNotFound = "Character Not Found";
                return Ok(characterNotFound);
            }

            return Ok(getCharacter);
        }

        // POST api/<CharacterController>
        [HttpPost]
        public async Task<IActionResult> CreateCharacterAsync(Character character)
        {
            var newCharacter = await characterService.CreateCharacterAsync(character.Name, character.Description, character.Age);

            return Created($"/api/character/{newCharacter}", newCharacter);
        }

        // PUT api/<CharacterController>/5
       // [HttpPut("{id}")]
      //  public async Task<IActionResult> UpdateCharacterById(int id, [FromBody] Character character)
       // {
           
        //}

        // DELETE api/<CharacterController>/5


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterAsync(int id)
        {
            var deleted = await characterService.DeleteCharacterAsync(id);

            if (deleted)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
