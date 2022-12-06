using Microsoft.EntityFrameworkCore;
using MySqlDemo.Models;
using System.Diagnostics;

namespace MySqlDemo.Persistence
{
    public class CarDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }

        public CarDbContext(DbContextOptions<CarDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var listBrands = new List<Brand>();
            listBrands.Add(new Brand { Id = 1, Name = "Brand1" });
            listBrands.Add(new Brand { Id = 2, Name = "Brand2" });
            listBrands.Add(new Brand { Id = 3, Name = "Brand3" });
            listBrands.Add(new Brand { Id = 4, Name = "Brand4" });

            var listColors = new List<Color>();
            listColors.Add(new Color { Id=1, ColorName = "ColorName1", ColorHex = "ColorHex1" });
            listColors.Add(new Color { Id=2, ColorName = "ColorName2", ColorHex = "ColorHex2" });
            listColors.Add(new Color { Id=3, ColorName = "ColorName3", ColorHex = "ColorHex3" });
            listColors.Add(new Color { Id=4, ColorName = "ColorName4", ColorHex = "ColorHex4" });

            var listCars = new List<Car>();
            listCars.Add(new Car { Id = 1, Name = "Car1",BrandId = 1,ColorId=1 });
            listCars.Add(new Car { Id = 2, Name = "Car2",BrandId = 2,ColorId=2 });
            listCars.Add(new Car { Id = 3, Name = "Car3",BrandId = 3,ColorId=3 });
            listCars.Add(new Car { Id = 4, Name = "Car4",BrandId = 4,ColorId=4 });

            modelBuilder.Entity<Brand>().HasData(listBrands);
            modelBuilder.Entity<Color>().HasData(listColors);
            modelBuilder.Entity<Car>().HasData(listCars);


            modelBuilder.Entity<Car>()
            .HasOne<Color>(c => c.Color)
            .WithMany(cl => cl.Cars)
            .HasForeignKey(c => c.ColorId);

            modelBuilder.Entity<Car>()
            .HasOne<Brand>(c => c.Brand)
            .WithMany(b => b.Cars)
            .HasForeignKey(c => c.BrandId);


            modelBuilder.Entity<Car>().Navigation(e => e.Brand).AutoInclude();
            modelBuilder.Entity<Car>().Navigation(e => e.Color).AutoInclude();
        }
    }
}
