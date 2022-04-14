using RetroModels;
using RetroDL;

namespace RetroBL;
public class StoresBL : IRetroBL<Stores>
{
    private readonly IRepository<Stores> _repo;

    public StoresBL(IRepository<Stores> repo)
    {
        _repo = repo;
    }

    public async Task<Stores> Add(Stores p_resource)
    {
        return await _repo.Add(p_resource);
    }

    public async Task<Stores> Delete(Stores p_resource)
    {
        return await _repo.Delete(p_resource);
    }

    public async Task<List<Stores>> GetAll()
    {
        return await _repo.GetAll();
    }

    public async Task<Stores> Update(Stores p_resource)
    {
        return await _repo.Update(p_resource);
    }
}
