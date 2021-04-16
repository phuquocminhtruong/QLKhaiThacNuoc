using DOLPHIN.Model;
using DOLPHIN.Repository.Common;
using DOLPHIN.Repository.Interfaces;
using System;

namespace DOLPHIN.Repository.Repositories
{
    /// <summary>
    /// ToTrinhRepository.
    /// </summary>
    public class ToTrinhRepository : GenericRepository<ToTrinh>, IToTrinhRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToTrinhRepository"/> class.
        /// </summary>
        /// <param name="context">context.</param>
        public ToTrinhRepository(IDbContext context)
            : base(context)
        {
        }
    }
}
