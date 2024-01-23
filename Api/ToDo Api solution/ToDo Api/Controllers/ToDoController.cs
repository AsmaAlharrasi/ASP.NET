using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo_Api.Context;
using ToDo_Api.Models;

namespace ToDo_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ToDoController : ControllerBase
	{
		private readonly ApplicationDpContext _context;
        public ToDoController(ApplicationDpContext context)
        {
            _context = context;
        }

		[HttpGet("id:int")]
		[ProducesResponseType(statusCode: 200)]
		[ProducesResponseType(statusCode: 404)]

		public ActionResult Get(int id)
		{
			if(id == 0)
			{
				return BadRequest();
			}
			var todo = _context.toDos.Find(id);
			if(todo is null)
			{
				return NotFound("ToDo is not found");
			}
			return Ok(todo);
		}

		[HttpGet]
		[ProducesResponseType(statusCode: 200)]
		[ProducesResponseType(statusCode: 404)]

		public ActionResult GetAll()
		{
			var todo = _context.toDos.ToList();
			if( todo.Count > 0)
			{
				return Ok(todo);
			}
			return NotFound();
		}
		#region GetAll with data
		//[HttpGet]
		//public IEnumerable<ToDo> GetAll()
		//{
		//	var todos = new List<ToDo>()
		//	{
		//		new ToDo() { Id = 1,Name="Api Study",Description="I have to study Api well"},
		//		new ToDo() { Id = 2,Name="Mvc Study",Description="I have to study Mvc well"}
		//	};
		//	return todos;

		//} 

		#endregion


		[HttpPost]
		public ActionResult Create(ToDo toDo)
		{
			if(ModelState.IsValid)
			{
				_context.toDos.Add(toDo);
				_context.SaveChanges();
				return Ok(toDo);
			}
			return BadRequest();
		}


		[HttpDelete("id:int")]
		public ActionResult Delete(int id)
		{
			if(id == 0)
			{
				return BadRequest();
			}
			var todo = _context.toDos.Find(id);
			_context.toDos.Remove(todo);
			_context.SaveChanges();
			if (todo is null)
			{
				return NotFound("ToDo is not found");
			}
			return Ok(todo);
		}

		[HttpPut]
		public ActionResult Update(ToDo todos)
		{
			var todo = _context.toDos.Find(todos);
			if( todo is null)
			{
				_context.toDos.Update(todos);
				_context.SaveChanges();
				return Ok(todos);
			}
			
			return BadRequest();
		}
	}
}
