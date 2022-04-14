using RetroModels;
using RetroDL;

namespace RetroBL;
public class CustomersBL : IRetroBL<Customers>
{
    private readonly IRepository<Customers> _repo;
    public CustomersBL(IRepository<Customers> repo)
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

    public async Task<List<Customers>> GetAll()
    {
        return await _repo.GetAll();
    }

    public async Task<Customers> Update(Customers p_resource)
    {
        return await _repo.Update(p_resource);
    }
}
