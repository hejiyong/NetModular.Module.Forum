using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Forum.Infrastructure.Repositories.MySql
{
    public class MarkRepository : SqlServer.MarkRepository
    {
        public MarkRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}