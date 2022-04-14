using RetroModels;
namespace RetroDL;
public class DbContextCartItemsRepo : IRepository<CartItems>
{
    private readonly RetroStoreDBContext _context;

    public DbContextCartItemsRepo(RetroStoreDBContext p_context)
    {
        _context = p_context;
    }

    public async Task<CartItems> Add(CartItems p_resource)
    {
        await _context.AddAsync(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<CartItems> Delete(CartItems p_resource)
    {
        _context.Remove(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public List<CartItems> GetAll()
    {
        return _context.CartItems.ToList<CartItems>();
    }

    public async Task<CartItems> Update(CartItems p_resource)
    {
        _context.Update(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }
}
