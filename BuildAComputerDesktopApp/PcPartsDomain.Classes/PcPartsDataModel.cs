using System.Data.Entity;

namespace PcPartsDomain.Classes
{
    class PcPartsContext : DbContext
    {
        public DbSet<PC> PC { get; set; }
        public DbSet<GPU> GPU { get; set; }
        public DbSet<CPU> CPU { get; set; }
        public DbSet<PowerSupply> PowerSupply { get; set; }
        public DbSet<MotherBoard> MotherBoard { get; set; }
        public DbSet<Memory> Memory { get; set; }

    }
}
