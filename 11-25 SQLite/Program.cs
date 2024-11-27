using ExpensesTraker_Library.Contexts;
using ExpensesTraker_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTraker_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ExpensesTrackerContext())
            {
                //context.Categories.Add(new Madels.Category { Name = "Food" });
                //context.Categories.Add(new Madels.Category { Name = "Transportation" });

                //context.SaveChanges();

                //context.Expenses.Add(new Expense
                //{
                //    Date = DateTime.Now,
                //    Amount = 350,
                //    Description = "Dinner",
                //    Category = context.Categories.FirstOrDefault()
                //});

                //context.SaveChanges();


                var expenses = context.Expenses.ToList();
                foreach (var expense in expenses)
                {
                    Console.WriteLine($"Date: {expense.Date}, Amount: {expense.Amount}, " +
                        $"Description: {expense.Description}, Category: {expense.Category.Name}");
                }



            }

        }
    }
}