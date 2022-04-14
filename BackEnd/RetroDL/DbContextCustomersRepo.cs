using RetroModels;
namespace RetroDL;
public class DbContextCustomersRepo : IRepository<Customers>
{
    private readonly RetroStoreDBContext _context;
    public DbContextCustomersRepo(RetroStoreDBContext context)
    {
        this._context = context;
    }

    public async Task<Customers> Add(Customers p_resource)
    {
        await _context.AddAsync(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
        
    }

    public async Task<Customers> Delete(Customers p_resource)
    {
        _context.Customers.Remove(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public List<Customers> GetAll()
    {
        return _context.Customers.ToList<Customers>();
    }

    public async Task<Customers> Update(Customers p_resource)
    {
        _context.Customers.Update(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }
}
