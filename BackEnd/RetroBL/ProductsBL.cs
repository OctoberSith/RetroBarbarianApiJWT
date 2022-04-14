using RetroModels;
using RetroDL;

namespace RetroBL;
public class ProductsBL : IRetroBL<Products>
{
    private readonly IRepository<Products> _repo;

    public ProductsBL(IRepository<Products> repo)
    {
        _repo = repo;
    }

    public async Task<Products> Add(Products p_resource)
    {
        return await _repo.Add(p_resource);
    }

    public async Task<Products> Delete(Products p_resource)
    {
        return await _repo.Delete(p_resource);
    }

    public async Task<List<Products>> GetAll()
    {
        return await _repo.GetAll();
    }

    public async Task<Products> Update(Products p_resource)
    {
        return await _repo.Update(p_resource);
    }
}
