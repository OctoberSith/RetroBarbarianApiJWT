using RetroModels;
using RetroDL;

namespace RetroBL;
public class InventoryBL : IRetroBL<Inventory>
{   
    private readonly DbContextInventoryRepo _repo;

    public InventoryBL(DbContextInventoryRepo repo)
    {
        _repo = repo;
    }

    public async Task<Inventory> Add(Inventory p_resource)
    {
        return await _repo.Add(p_resource);
    }

    public async Task<Inventory> Delete(Inventory p_resource)
    {
        return await _repo.Delete(p_resource);
    }

    public List<Inventory> GetAll()
    {
        return _repo.GetAll();
    }

    public async Task<Inventory> Update(Inventory p_resource)
    {
        return await _repo.Update(p_resource);
    }
}
