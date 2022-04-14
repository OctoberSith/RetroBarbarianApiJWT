using RetroModels;
namespace RetroDL;
public class DbContextInventoryRepo : IRepository<Inventory>
{
    private readonly RetroStoreDBContext _context;

    public DbContextInventoryRepo(RetroStoreDBContext context)
    {
        _context = context;
    }

    public async Task<Inventory> Add(Inventory p_resource)
    {
        await _context.AddAsync(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<Inventory> Delete(Inventory p_resource)
    {
        _context.Remove(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }
    public List<Inventory> GetAll()
    {
        return _context.Inventory.ToList<Inventory>();
    }

    public async Task<Inventory> Update(Inventory p_resource)
    {
        _context.Update(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }
    
}
