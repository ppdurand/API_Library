using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebAPi.Context;

namespace WebApi.Service;

public class BookService
{
    private readonly DataContext _context;

    public BookService(DataContext context)
    {
        _context = context;
    }

    private List<Book> books = new List<Book>();

    public IEnumerable<Book> getBook()
    {
        return _context.Book!.ToList();
    }

    // public IEnumerable<Book> getBookById(int id)
    // {
    //     var book = books.Find(b => b.Id == id);
    //     if (book == null)
    //     {
    //         return "Livro não encontrado";
    //     }
    //     return book;
    // }

    public string postBook(Book book)
    {
        _context.Book?.Add(book);
        _context.SaveChanges();
        return "Cadastrado com sucesso";
    }

    public string updateBook(int id, [FromBody] Book book)
    {
        _context.Book?.Update(book);
        _context.SaveChanges();
        return $"Livro alterado com sucesso";
    }

    public string deleteBook(int id)
    {
        var book = _context.Book!.FirstOrDefault(b => b.Id == id);
        _context.Book?.Remove(book!);
        _context.SaveChanges();
        return $"Livro '{book?.Name}' deletado!";
        // var book = books.Find(b => b.Id == id);
        // if(book == null)
        // {
        //     return "Livro não encontrado";
        // }
        // books.Remove(book);
        // return "Livro removido";
    }
}