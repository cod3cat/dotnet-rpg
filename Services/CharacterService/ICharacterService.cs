using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        public Task<ServiceResponse<List<Character>>> GetAllCharacters();

        public Task<ServiceResponse<Character>> GetCharacterById(int id);

        public Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}