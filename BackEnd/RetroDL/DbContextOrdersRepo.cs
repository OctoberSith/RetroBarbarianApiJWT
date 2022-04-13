using RetroModels;
namespace RetroDL;
public class DbContextOrdersRepo : IRepository<Orders>
{
    public Task<Orders> Add(Orders p_resource)
    {
        throw new NotImplementedException();
    }

    public Task<Orders> Delete(Orders p_resource)
    {
        throw new NotImplementedException();
    }

    public Task<List<Orders>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Orders> Update(Orders p_resource)
    {
        throw new NotImplementedException();
    }
}
