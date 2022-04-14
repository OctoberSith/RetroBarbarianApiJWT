using RetroModels;
namespace RetroDL;
public class DbContextStoresRepo : IRepository<Stores>
{
    private readonly RetroStoreDBContext _context;

    public DbContextStoresRepo(RetroStoreDBContext context)
    {
        _context = context;
    }

    public async Task<Stores> Add(Stores p_resource)
    {
        await _context.AddAsync(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<Stores> Delete(Stores p_resource)
    {
        _context.Remove(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public List<Stores> GetAll()
    {
        return _context.Stores.ToList<Stores>();
    }

    public async Task<Stores> Update(Stores p_resource)
    {
        _context.Update(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }
}
