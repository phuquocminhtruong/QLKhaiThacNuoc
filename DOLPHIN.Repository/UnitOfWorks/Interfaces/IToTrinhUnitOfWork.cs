using DOLPHIN.Repository.Common;
using DOLPHIN.Repository.Interfaces;

namespace DOLPHIN.Repository.UnitOfWorks.Interfaces
{
    /// <summary>
    /// Interface ToTrinhUnitOfWork.
    /// </summary>
    public interface IToTrinhUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Gets ToTrinhRepository.
        /// </summary>
        IToTrinhRepository ToTrinhRepository { get; }
    }
}
