using Microsoft.EntityFrameworkCore;
using SOFOIAN_EF_HT1.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFOIAN_EF_HT1
{
    public class MyDbContext : DbContext
    {
        /// <summary>
        /// Создание таблицы Orders
        /// </summary>
       public DbSet<OrderModel> Orders { get; set; } = null!;
        

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MyDbContext()
        {
            //Database.EnsureCreated();//если БД не создана то она создастся

            //var canConnect = Database.CanConnect();//дает ответ, можем подключиться к бд или нет
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=s-dev-01; Database=SOF_EF_HT1; Trusted_Connection=True; Encrypt=false") ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnUserCreated(modelBuilder);
        }
        private void OnUserCreated(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=30, Summ = 52000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=31, Summ = 53555.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=32, Summ = 2652000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=33, Summ = 535872000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=34, Summ = 52025600.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=35, Summ = 52000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=36, Summ = 53555.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=37, Summ = 2652000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id=38, Summ = 535872000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 39 , Summ = 52025600.33 });
        }
    }
}
