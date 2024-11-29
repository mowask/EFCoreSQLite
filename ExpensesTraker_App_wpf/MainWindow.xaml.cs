using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExpensesTraker_Library.Contexts;
using ExpensesTraker_Library.Models;
using ExpensesTraker_Library.Repositories;

namespace ExpensesTraker_App_wpf
{  
    public partial class MainWindow : Window
    {
        private ExpensesTrackerContext _context;
        private ExpenseRepository _repository;

        public MainWindow()
        {
            InitializeComponent();

            _context = new ExpensesTrackerContext();
            _repository = new ExpenseRepository(_context);

            dataGridCategories.ItemsSource = _repository.GetAllCategoriesObservable();

            buttonAddCategory.Click += ButtonAddCategory_Click;
        }

        private void ButtonAddCategory_Click(object sender, RoutedEventArgs e)
        {
            var categoryName = textBoxCategoryName.Text.Trim();
            if (categoryName != string.Empty)
            {
                _repository.AddCategory(new Category()
                {
                    Name = textBoxCategoryName.Text,
                });
            }
            //else
            //{
            //    MessageBox.Show("Category Name can't be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }


    }
}