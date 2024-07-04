using EntityFW.model.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFW.model
{
    internal class TestE : DbContext
    {
        ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddFilter(DbLoggerCategory.Database.Name, LogLevel.Information);
            builder.AddConsole();
        });
        public DbSet<Product> products { get; set; }

        public DbSet<Category> categories { get; set; }

        private string connectionString = "Server=TTANH; Database=db01; User Id=sa; Password=1234; TrustServerCertificate=True";
        // function config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // fluent api

            //var entity = modelBuilder.Entity(typeof(Product));
            // or
            //  var entity = modelBuilder.Entity<Product>();

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.IDProduct);
                entity.HasIndex(p => p.Quantity).IsUnique(true);

                entity.HasOne(p => p.Category) // make relationship 1-n
                    .WithMany() // khong co properti nao cua Catalogi co trong product
                    .HasForeignKey("catid")
                    .OnDelete(DeleteBehavior.Cascade) //dat ten fk // xoa phan 1 thi phan n xoa theo
                                                      // DeleteBehavior.NoAction : cac entity lien quankhong bi anh huong khi xoa
                    .HasConstraintName("khoa_ngoaip_pro_cate");  // dat ten cho khoa ngoai
                                                                 // 

                // set property

                entity.Property(p => p.NameProduct)
                .HasColumnName("nemProductFlu")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired(false) // cos kha nang nhan value null
                ;
                
            });
        }
    }
}
