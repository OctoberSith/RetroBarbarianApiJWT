using RetroModels;
using RetroDL;

namespace RetroBL;
public class CartItemsBL : IRetroBL<CartItems>
{
    private readonly IRepository<CartItems> _repo;

    public CartItemsBL(IRepository<CartItems> repo)
    {
        _repo = repo;
    }

    public async Task<CartItems> Add(CartItems p_resource)
    {
        return await _repo.Add(p_resource);
    }

    public async Task<CartItems> Delete(CartItems p_resource)
    {
        return await _repo.Delete(p_resource);
    }

    public async Task<List<CartItems>> GetAll()
    {
        return await _repo.GetAll();
    }

    public async Task<CartItems> Update(CartItems p_resource)
    {
        return await _repo.Update(p_resource);
    }
}