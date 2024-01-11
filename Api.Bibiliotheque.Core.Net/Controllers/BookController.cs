using Api.Bibiliotheque.Core.Net.Filters;
using Api.Bibiliotheque.Core.Net.Interfaces;
using Api.Bibiliotheque.Core.Net.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Bibiliotheque.Core.Net.Controllers
{
    
    [Route("api/maroute/[controller]")]
    [Produces("application/json")]
    [DisabledFilter]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        /// <summary>
        /// Obtains the list of books from the library.
        /// </summary>
        /// <remarks>
        /// Example of a request:
        /// POST /monget/mongetge {with in id = "id", and a value = "value", ...}
        /// </remarks>
        /// <response code="400">Error finding the request</response>
        /// <response code="200">A list of books</response>
        /// <response code="401">Authentication required</response>
        /// <returns>Returns a list of books</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]        
        [HttpGet("monget/mongetget")]        
        public async Task<ActionResult<List<Models.BookModel>>> Get()
        {
            var result = await _service.GetBooks();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.BookModel>> Get(int id)
        {
            var result = await _service.GetBook(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Models.BookModel>> Post(BookModel book)
        {
            var result = await _service.AddBook(book);
            return CreatedAtAction("Post", result);
        }

        [HttpPut]
        public async Task<ActionResult<Models.BookModel>> Put(int id, BookModel book)
        {
            var result = await _service.UpdateBook(id,book);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<Models.BookModel>> Delete(int id)
        {
            var result = await _service.DeleteBook(id);
            return Ok(result);
        }
    }
}
