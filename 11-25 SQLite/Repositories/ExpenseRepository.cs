using ExpensesTraker_Library.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTraker_Library.Repositories
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
