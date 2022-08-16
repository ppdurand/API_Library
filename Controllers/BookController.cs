using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.Service;
using WebAPi.Context;

namespace WebApi.Controller;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly BookService _bookservice;
    private readonly DataContext _context;

    public BookController(DataContext context)
    {
        _bookservice = new BookService(context);
    }
    
    [HttpGet]
    public IEnumerable<Book> getBook()
    {
        return _bookservice.getBook();
    }

    // [HttpGet("{id}")]
    // public  IEnumerable<Book> getBookById(int id)
    // {
    //     return _bookservice.getBookById(id);
    // }


    [HttpPost]
    public string postBook([FromBody] Book book)
    {
        return _bookservice.postBook(book);
    }

    [HttpPut("{id:int}")]
    public string updateBook(int id, [FromBody] Book book)
    {
        if(id != book.Id) return "Id errado";
        return _bookservice.updateBook(id, book);
    }
    
    [HttpDelete("{id:int}")]
    public string deleteBook(int id)
    {
    return _bookservice.deleteBook(id);
    }
}