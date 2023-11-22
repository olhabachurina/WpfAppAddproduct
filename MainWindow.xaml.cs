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

namespace WpfAppAddproduct
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddProductButtonClick(object sender, RoutedEventArgs e)
        {
            string newProduct = newProductTextBox.Text;

            if (!string.IsNullOrWhiteSpace(newProduct))
            {
                Paragraph paragraph = new Paragraph(new Run(newProduct));
                ListItem newItem = new ListItem(paragraph);
                productList.ListItems.Add(newItem);
                newProductTextBox.Clear();
            }
        }
    }
}

