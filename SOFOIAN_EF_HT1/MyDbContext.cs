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
        DbSet<OrderModel> Orders { get; set; } = null!;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MyDbContext()
        {
            Database.EnsureCreated();//если БД не создана то она создастся

            var canConnect = Database.CanConnect();//дает ответ, можем подключиться к бд или нет
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=s-dev-01; Database=SOF_EF_HT1; Trusted_Connection=True; Encrypt=false");
        }
    }
}
