using _2302C2FirstAPI.Data;
using _2302C2FirstAPI.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2302C2FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly _2302c2webApiContext db;
        public TeamController(_2302c2webApiContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public IActionResult GetTeams()
        {
            return Ok(db.Teams.ToList());
        }

        //[HttpPost]
        //public IActionResult AddTeam(Team team)
        //{
        //    var addedTeam = db.Add(team);
        //    db.SaveChanges();
        //    return Ok(addedTeam.Entity);
        //}

        [HttpPost]
        public IActionResult CreateTeam(TeamDTO teamDTO)
        {
            if (ModelState.IsValid)
            {
                //Object Mapping
                Team newTeam = new Team()
                {
                    Name=teamDTO.Name,
                    Description=teamDTO.Description

                };

                var addedTeam = db.Teams.Add(newTeam);
                db.SaveChanges();
                return Ok(addedTeam.Entity);

            }
            else
            {
                return BadRequest("Invalid Data");
            }

        }

        [HttpPut]
        public IActionResult EditTeam(int Id,TeamDTO teamDTO)
        { 
            var teamData = db.Teams.FirstOrDefault(a=>a.Id==Id);
            if(teamData != null)
            {
                teamData.Name = teamDTO.Name;
                teamData.Description = teamDTO.Description;

                var editedTeam = db.Teams.Update(teamData);
                db.SaveChanges();
                return Ok(editedTeam.Entity);
            }
            else
            {
                return NotFound("Invalid User");
            }
            
        }
        [HttpDelete]
        public IActionResult DeleteTeam(int Id)
        {
            var teamData = db.Teams.FirstOrDefault(a => a.Id == Id);
            if (teamData != null)
            {
                var deletedTeam = db.Teams.Remove(teamData);
                db.SaveChanges();
                return Ok(deletedTeam.Entity);
            }
            else
            {
                return NotFound("Invalid User");
            }


        }


    }
}
