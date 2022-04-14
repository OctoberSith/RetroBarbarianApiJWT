using Microsoft.EntityFrameworkCore;
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
        await _context.Database.BeginTransactionAsync();
        await _context.AddAsync(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<Orders> Delete(Orders p_resource)
    {
        await _context.Database.BeginTransactionAsync();
        _context.Remove(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<List<Orders>> GetAll()
    {
        return await _context.Orders.ToListAsync<Orders>();
    }

    public async Task<Orders> Update(Orders p_resource)
    {
        await _context.Database.BeginTransactionAsync();
        _context.Update(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
    }
}
