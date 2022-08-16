using WebAPi.Context;

namespace WebApi.Repository.Implementation;

public class BaseRepository : IBaseRepository
{
    private readonly DataContext _context;

    public BaseRepository(DataContext context)
    {
        _context = context;
    }
    public void Add<TEntity>(TEntity entity) where TEntity : class
    {
        _context.Add<TEntity>(entity);
        SaveChanges();
    }
    public void Update<TEntity>(TEntity entity) where TEntity : class
    {
        throw new NotImplementedException();
    }
    public void Delete<TEntity>(TEntity entity) where TEntity : class
    {
        throw new NotImplementedException();
    }
    public IEnumerable<TEntity> List<TEntity>() where TEntity : class
    {
        throw new NotImplementedException();
    }

    public bool SaveChanges()
    {
        return _context.SaveChanges() > 0;
    }
}
