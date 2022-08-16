using WebApi.Model;
namespace WebApi.Repository;

public interface IBookRepository : IBaseRepository
{
    Book GetByInitials();    
}