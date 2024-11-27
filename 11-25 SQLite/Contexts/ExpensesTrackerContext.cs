using _11_25_SQLite.Madels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_25_SQLite.Contexts
{
    public class ExpensesTrackerContext    : DbContext
    {

        // dbset для категорий расходов
        public DbSet <Category> Categories { get; set; }

        // dbset для самих расходов
        public DbSet<Expense> Expenses { get; set; }

        //конструктор класса
        public ExpensesTrackerContext()
        {
            // удаляем существующую базу данных, если она есть
            //  Database.EnsureDeleted();

            // создаем новую базу данных, если ее нет
            Database.EnsureCreated();
        }


        // метод для настройки подключения к базе данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // используем SQLite базу данных с указанным именем
            optionsBuilder.UseSqlite("Data Source=Expenses.db");
        }


    }
}
