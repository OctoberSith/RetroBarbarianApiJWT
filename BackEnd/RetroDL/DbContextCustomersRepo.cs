using Microsoft.EntityFrameworkCore;
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
        await _context.Database.BeginTransactionAsync();
        await _context.AddAsync(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
        
    }

    public async Task<Customers> Delete(Customers p_resource)
    {
         await _context.Database.BeginTransactionAsync();
        _context.Remove(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
    }

    public async Task<List<Customers>> GetAll()
    {
        return await _context.Customers.ToListAsync<Customers>();
    }

    public async Task<Customers> Update(Customers p_resource)
    {
        await _context.Database.BeginTransactionAsync();
        _context.Update(p_resource);
        await _context.Database.CommitTransactionAsync();
        await _context.SaveChangesAsync();
        return p_resource;
    }
}
