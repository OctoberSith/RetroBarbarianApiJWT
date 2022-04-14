using RetroModels;
namespace RetroDL;
public class DbContextOrdersRepo : IRepository<Orders>
{
    private readonly RetroStoreDBContext _context;

    public DbContextOrdersRepo(RetroStoreDBContext context)
    {
        _context = context;
    }

    public async Task<Orders> Add(Orders p_resource)
    {
        await _context.AddAsync(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<Orders> Delete(Orders p_resource)
    {
        _context.Remove(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public List<Orders> GetAll()
    {
        return _context.Orders.ToList<Orders>();
    }

    public async Task<Orders> Update(Orders p_resource)
    {
        _context.Update(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }
}
