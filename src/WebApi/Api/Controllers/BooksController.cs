using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        public BooksController(IBookRepository bookRepository,IMapper _mapper)
        {
            _bookService = new BookService(bookRepository, _mapper);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _bookService.GetAllBooks();
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
