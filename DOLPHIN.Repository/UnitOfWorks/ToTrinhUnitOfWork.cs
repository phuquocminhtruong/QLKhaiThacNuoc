using DOLPHIN.Model;
using DOLPHIN.Repository.Common;
using DOLPHIN.Repository.Interfaces;
using DOLPHIN.Repository.Repositories;
using DOLPHIN.Repository.UnitOfWorks.Interfaces;

namespace DOLPHIN.Repository.UnitOfWorks
{
    /// <summary>
    /// ToTrinhUnitOfWork.
    /// </summary>
    public class ToTrinhUnitOfWork : UnitOfWorkBase, IToTrinhUnitOfWork
    {
        private IToTrinhRepository toTrinhRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToTrinhUnitOfWork"/> class.
        /// </summary>
        /// <param name="dbcontext">dbcontext.</param>
        public ToTrinhUnitOfWork(IDbContext dbcontext)
            : base(dbcontext)
        {
        }

        /// <inheritdoc/>
        public IToTrinhRepository ToTrinhRepository => this.toTrinhRepository ?? (this.toTrinhRepository = new ToTrinhRepository(this.dbContext));
    }
}
