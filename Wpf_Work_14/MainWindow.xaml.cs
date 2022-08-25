using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_Work_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Бананы",
                ProdPrice = 70,
                ProdImage = "Data/банан.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Кокосы",
                ProdPrice = 170,
                ProdImage = "Data/кокос.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Ананас",
                ProdPrice = 260,
                ProdImage = "Data/ананас.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Пылесос",
                ProdPrice = 7000,
                ProdImage = "Data/пылесос.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Кепка",
                ProdPrice = 35,
                ProdImage = "Data/кепка.jpg",
                ProductCategory = ProductCategorys.Сlothes
            });
            products.Add(new Product()
            {
                ProdName = "Брюки",
                ProdPrice = 35000,
                ProdImage = "Data/брюки.jpg",
                ProductCategory = ProductCategorys.Сlothes
            });
            listBox.ItemsSource = products;
        }
    }
}
