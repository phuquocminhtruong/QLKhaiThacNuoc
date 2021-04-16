using DOLPHIN.Model;
using DOLPHIN.Repository.Common;
using System;
using System.Threading.Tasks;

namespace DOLPHIN.Repository.Interfaces
{
    /// <summary>
    /// Category Repostory Interface.
    /// </summary>
    public interface ICategoryRepository : IGenericRepository<CanBo>
    {
        /// <summary>
        /// GetCategoryById.
        /// </summary>
        /// <param name="categoryId">categoryId.</param>
        /// <returns>Category.</returns>
        Task<CanBo> GetCategoryById(Guid categoryId);
    }
}
