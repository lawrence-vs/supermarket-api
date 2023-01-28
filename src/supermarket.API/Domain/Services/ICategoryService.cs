using supermarket.API.Domain.Models;

namespace supermarket.API.Domain.Services
{
    public interface ICategoryService
    {
        /// <summary>
        ///    The implementation of ListAsync mehtod must 
        ///    asyncronously return an enumeration of categories
        ///    Asyncronously required as the db has to complete an operation to return the data
        ///    Dependench injection:
        ///       - Define  behavior using interface, 
        ///       - Create class to implement interface, 
        ///       - Bind the references from the interface to the class you created
        /// </summary>
        /// <returns>
        ///     Task<IEnumberable<Category>>
        /// </returns>
        Task<IEnumerable<Category>> ListAsync();
    }
}
