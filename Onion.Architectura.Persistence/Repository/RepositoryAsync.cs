using Ardalis.Specification.EntityFrameworkCore;
using Onion.Architectura.Persistence.Contexts;
using Onion.Architecture.Application.Interfaces;

namespace Onion.Architectura.Persistence.Repository
{
    public class RepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {

        private readonly ApplicationDbContext dbContext;

        public RepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
