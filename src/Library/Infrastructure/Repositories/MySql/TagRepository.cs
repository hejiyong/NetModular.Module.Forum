using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Forum.Infrastructure.Repositories.MySql
{
    public class TagRepository : SqlServer.TagRepository
    {
        public TagRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}