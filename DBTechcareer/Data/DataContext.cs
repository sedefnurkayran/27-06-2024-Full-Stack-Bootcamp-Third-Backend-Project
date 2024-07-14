using Microsoft.EntityFrameworkCore;

namespace DBTechcareer.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Student> Ogrenciler => Set<Student>();
        public DbSet<Bootcamp> Bootcamps => Set<Bootcamp>();
        public DbSet<BootcampRegistration> KursKayitlari => Set<BootcampRegistration>();
    }
}