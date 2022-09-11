using Microsoft.EntityFrameworkCore;

namespace DigitalTwin.Data.Database;

public class DigitalTwinContext : DbContext
{
    public DigitalTwinContext(DbContextOptions<DigitalTwinContext> options) : base(options)
    {
    }
}