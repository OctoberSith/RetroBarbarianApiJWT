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
        _context.Add(p_resource);
        _context.SaveChanges();
        return p_resource;
        
    }

    public async Task<Customers> Delete(Customers p_resource)
    {
        _context.Customers.Remove(p_resource);
        _context.SaveChanges();
        return p_resource;
    }

    public async Task<List<Customers>> GetAll()
    {
        return _context.Customers.ToList<Customers>();
    }

    public async Task<Customers> Update(Customers p_resource)
    {
        _context.Customers.Update(p_resource);
        _context.SaveChanges();
        return p_resource;
    }
}
