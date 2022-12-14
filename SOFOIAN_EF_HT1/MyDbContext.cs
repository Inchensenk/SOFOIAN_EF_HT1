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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb; Database=SOF_EF_HT1; Trusted_Connection=True; Encrypt=false") ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnUserCreated(modelBuilder);
        }
        private void OnUserCreated(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 30, Summ = 52000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 31, Summ = 53555.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 32, Summ = 2652000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 33, Summ = 535872000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 34, Summ = 52025600.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 35, Summ = 52000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 36, Summ = 53555.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 37, Summ = 2652000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 38, Summ = 535872000.33 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 39, Summ = 52025600.33 });


            //Изменение поля Date в таблице Orders

            modelBuilder.Entity<OrderModel>().ToSqlQuery("USE Orders " +
                " UPDATE Orders " + "SET Date = '2022-05-21' " + " WHERE Id=30 \n"+
                                                      
                " UPDATE Orders " + " SET Date = '2022-03-22' " + " WHERE Id=31\n" +
                                                     
                " UPDATE Orders " + " SET Date = '2022-04-19' " + " WHERE Id=32\n" +
                                                         
                " UPDATE Orders " + " SET Date = '2022-06-15' " + " WHERE Id=33\n" +
                                                         
                " UPDATE Orders " + " SET Date = '2022-09-12' " + " WHERE Id=34\n" +
                                                         
                " UPDATE Orders " + " SET Date = '2022-07-07' " + " WHERE Id=35\n" +
                                                         
                " UPDATE Orders " + " SET Date = '2022-02-11' " + " WHERE Id=36\n" +
                                                         
                " UPDATE Orders " + " SET Date = '2022-08-04' " + " WHERE Id=37\n" +
                                                         
                " UPDATE Orders " + " SET Date = '2022-01-14' " + " WHERE Id=38\n" +
                                                         
                " UPDATE Orders " + " SET Date = '2022-01-14' " + " WHERE Id=38\n" +
                                                         
                " UPDATE Orders " + " SET Date = '2022-12-21' " + " WHERE Id=39\n");
            
            
        }
    }
}
