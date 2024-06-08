using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        //api/projects?querry=net core
        [HttpGet]
        public IActionResult Get(string querry)
        {
            //filtrar todos ou filtrar

            return Ok();
        }

        //api/projects/599
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //buscar o projeto

            //return NotFound

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            //cadastrar o projeto

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        //api/project/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CreateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            //Atualizo o objeto

            return NoContent();
        }

        //api/project/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Remover

            //buscar, se na existir, retorna NotFound
            return NoContent();
        }

        //api/projects/1/comments POST
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        //api/project/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }

    }
}
