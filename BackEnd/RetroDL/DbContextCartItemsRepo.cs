using Microsoft.EntityFrameworkCore;
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
        await _context.Database.BeginTransactionAsync();
        await _context.AddAsync(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<CartItems> Delete(CartItems p_resource)
    {
        await _context.Database.BeginTransactionAsync();
        _context.Remove(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<List<CartItems>> GetAll()
    {
        return await _context.CartItems.ToListAsync<CartItems>();
    }

    public async Task<CartItems> Update(CartItems p_resource)
    {
        await _context.Database.BeginTransactionAsync();
        _context.Update(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
    }
}
