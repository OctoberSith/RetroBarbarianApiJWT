using RetroModels;
namespace RetroDL;
public class DbContextProductsRepo : IRepository<Products>
{
    private readonly RetroStoreDBContext _context;

    public DbContextProductsRepo(RetroStoreDBContext context)
    {
        _context = context;
    }

    public async Task<Products> Add(Products p_resource)
    {
        await _context.AddAsync(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<Products> Delete(Products p_resource)
    {
        _context.Remove(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public List<Products> GetAll()
    {
        return _context.Products.ToList<Products>();
    }

    public async Task<Products> Update(Products p_resource)
    {
        _context.Update(p_resource);
        await _context.SaveChangesAsync();
        return p_resource;
    }
}
