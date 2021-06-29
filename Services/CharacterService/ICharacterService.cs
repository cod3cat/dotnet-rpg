using System.Collections.Generic;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        public List<Character> GetAllCharacters();

        public Character GetCharacterById(int id);

        public List<Character> AddCharacter(Character newCharacter);
    }
}