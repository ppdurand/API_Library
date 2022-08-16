using WebAPi.Context;

namespace WebApi.Repository.Implementation;

public class BookRepository : BaseRepository, IBookRepository
{
    private readonly BookContext _context;
    public BookRepository(BookContext context) : base(context)
    {
        _context = context;
    }

    public Book GetByInitials
    {
        
    }
}