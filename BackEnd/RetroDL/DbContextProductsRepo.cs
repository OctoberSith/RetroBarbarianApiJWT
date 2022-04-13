using RetroModels;
namespace RetroDL;
public class DbContextProductsRepo : IRepository<Products>
{
    public Task<Products> Add(Products p_resource)
    {
        throw new NotImplementedException();
    }

    public Task<Products> Delete(Products p_resource)
    {
        throw new NotImplementedException();
    }

    public Task<List<Products>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Products> Update(Products p_resource)
    {
        throw new NotImplementedException();
    }
}
