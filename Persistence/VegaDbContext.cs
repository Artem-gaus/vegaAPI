using Microsoft.EntityFrameworkCore;

namespace vegaAPI.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {}
    }
}