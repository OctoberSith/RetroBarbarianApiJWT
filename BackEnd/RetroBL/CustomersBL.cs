using RetroModels;
using RetroDL;

namespace RetroBL;
public class CustomersBL : IRetroBL<Customers>
{
    private readonly DbContextCustomersRepo _repo;
    public CustomersBL(DbContextCustomersRepo repo)
    {
        _repo = repo;
    }

    public async Task<Customers> Add(Customers p_resource)
    {
       return await _repo.Add(p_resource);
    }

    public async Task<Customers> Delete(Customers p_resource)
    {
       return await _repo.Delete(p_resource);
    }

    public List<Customers> GetAll()
    {
        return _repo.GetAll();
    }

    public async Task<Customers> Update(Customers p_resource)
    {
        return await _repo.Update(p_resource);
    }
}
