using BookLibrary;
using BookRest.Managers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly BooksManager _manager = new BooksManager();

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{isbn}")]
        public Book Get(string isbn)
        {
            return _manager.GetByIsbn(isbn);
        }

        // POST api/<BooksController>
        [HttpPost]
        public Book Post([FromBody] Book book)
        {
            return _manager.Add(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{isbn}")]
        public Book Put(string isbn, [FromBody] Book value)
        {
            return _manager.Update(isbn, value);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{isbn}")]
        public Book Delete(string isbn)
        {
            return _manager.Delete(isbn);
        }
    }
}
