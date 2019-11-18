using System;

using Microsoft.EntityFrameworkCore;

namespace Api.Dal
{
    public class RepertoireContext: DbContext
    {
        public RepertoireContext() { }
        public RepertoireContext(DbContextOptions<RepertoireContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=postgresql-oceanstudio.alwaysdata.net;Database=oceanstudio_entreprise;Username=oceanstudio;Password=bil442.ad");
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Ville> Ville { get; set; }

	}
}
