using _11_25_SQLite.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_25_SQLite.Repositories
{
    public class ExpenseRepository
    {
        private readonly ExpensesTrackerContext _context;

        public ExpenseRepository ( ExpensesTrackerContext context)
        {
            _context = context;
        }
    }
}
