namespace RetroDL;
public interface IRepository<T>
{
         /// <summary>
        /// Add a Resource to Repository
        /// </summary>
        /// <param name="p_resource"></param>
        /// <returns></returns>
        Task<T> Add(T p_resource);
        /// <summary>
        /// Get all the Resources in a Database
        /// </summary>
        /// <returns></returns>
        Task<List<T>> GetAll();
        /// <summary>
        /// Updates the Resources in a Database
        /// </summary>
        /// <param name="p_resource"></param>
        /// <returns></returns>
        Task<T> Update(T p_resource);
        /// <summary>
        /// Deletes a Resource from the Database
        /// </summary>
        /// <param name="p_resource"></param>
        /// <returns></returns>
        Task<T> Delete(T p_resource);
        
}
