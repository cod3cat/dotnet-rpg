using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>(){
            new Character(),
            new Character{ Id = 1, Name = "Sam"}
        };
        
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Character> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost("AddCharacter")]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}