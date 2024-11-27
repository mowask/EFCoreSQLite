using ExpensesTraker_Library.Contexts;
using ExpensesTraker_Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTraker_Library.Repositories
{
    public class ExpenseRepository
    {
        private readonly ExpensesTrackerContext _context;

        public ExpenseRepository(ExpensesTrackerContext context)
        {
            _context = context;
        }

        public ObservableCollection<Category> GetAllCategoriesObservable()
        {
            _context.Categories.Load();
            return _context.Categories.Local.ToObservableCollection();
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges(true);
        }

        public void RemoveCategory(int categoryId)
        {
            var category = _context.Categories.Find(categoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges(true);
            }
        }

        public void AddExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges(true); 
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void RemoveExpense(int expenseId)
        {
            var expense = _context.Expenses.Find(expenseId);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                _context.SaveChanges(true);
            }
        }       

         public IEnumerable<Expense> GetAllExpenses () 
        {
            return _context.Expenses.ToList();
        }

        



    }
}
