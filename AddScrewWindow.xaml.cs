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
using System.Windows.Shapes;

namespace ScrewCart
{
    /// <summary>
    /// Interaktionslogik für AddScrewWindow.xaml
    /// </summary>
    public partial class AddScrewWindow : Window
    {
        public double Amount { get; set; }
        public AddScrewWindow()
        {
            InitializeComponent();
        }

        private void OnBuy(object sender, RoutedEventArgs e)
        {
            Close();  
        }
    }
}
