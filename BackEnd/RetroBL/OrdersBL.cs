using RetroModels;
using RetroDL;

namespace RetroBL;
public class OrdersBL : IRetroBL<Orders>
{
    private readonly DbContextOrdersRepo _repo;

    public OrdersBL(DbContextOrdersRepo repo)
    {
        _repo = repo;
    }

    public async Task<Orders> Add(Orders p_resource)
    {
        return await _repo.Add(p_resource);
    }

    public async Task<Orders> Delete(Orders p_resource)
    {
        return await _repo.Delete(p_resource);
    }

    public List<Orders> GetAll()
    {
        return _repo.GetAll();
    }

    public async Task<Orders> Update(Orders p_resource)
    {
        return await _repo.Update(p_resource);
    }
}
