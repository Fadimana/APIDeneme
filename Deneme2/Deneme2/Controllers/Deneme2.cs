using Business.Layer.Interface;
using DataAccsess.Layer.Entitys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Deneme2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Deneme2 : ControllerBase
    {

        private readonly IBookBusinessServices1 _bookBusinessServices;

        public Deneme2(IBookBusinessServices1 bookBusinessServices)
        {
            _bookBusinessServices = bookBusinessServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(Book book)
        {
            var book1 = await _bookBusinessServices.CreateBook(book);

            //return BadRequest();

            return Ok(book1);

        }

        [HttpGet("{Id}")]

        public async Task<IActionResult>BookGetId(int id)
        {
            
            var book2=await _bookBusinessServices.GetById(id);
            
            return Ok(book2);
        }

        [HttpPut]
        public async Task<IActionResult>UpdateBook(Book book)
        {
            var book3=await _bookBusinessServices.UpdateBook(book);
           
            return Ok(book3);
        }

    //    [Route("DeleteBook")]
        [HttpDelete]

        public async Task<IActionResult>DeleteBook(int id)
        {
            var book4 = await _bookBusinessServices.DeleteBook(id);
               
                return Ok(book4);
        }
        [HttpGet]
        public async Task<IActionResult> GetBookById()
        {
            var book5 = await _bookBusinessServices.GetBookById();
            return Ok(book5);
        }


    }
}
