using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Каравай",
                ProductPrice = 50,
                ProductImage = "/Data/karavay.jpg",
                ProductCategory = ProductCategories.Еда
            });
            products.Add(new Product()
            {
                ProductName = "Батон",
                ProductPrice = 36,
                ProductImage = "/Data/loaf.jpg",
                ProductCategory = ProductCategories.Еда
            });
            products.Add(new Product()
            {
                ProductName = "Платье",
                ProductPrice = 5600,
                ProductImage = "/Data/dress.jpg",
                ProductCategory = ProductCategories.Одежда
            });
            products.Add(new Product()
            {
                ProductName = "Фен",
                ProductPrice = 2800,
                ProductImage = "/Data/fen.jpg",
                ProductCategory = ProductCategories.БытоваяТехника
            });
            product.ItemsSource = products;
        }


    }
}
