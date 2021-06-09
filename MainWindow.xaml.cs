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

namespace ScrewCart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Screw> Screws { get; set; } = new()
        {
            new(
                "M4, 6mm",
                1.35,
                0.133
            ),
            new(
                "M4, 8mm",
                1.40,
                0.149
            ),
            new(
                "M5, 6mm",
                1.65,
                0.218
            ),
            new(
                "M5, 8mm",
                1.80,
                0.238
            )
        };

        public List<CartScrew> CartScrews { get; set; } = new();

        public string[] MeasurementUnits { get; set; } = new string[2] { "kg", "Package" };
        public string CurrentUnit { get; set; }
        public string Amount { get; set; } = "";


        public MainWindow()
        {
            CurrentUnit = MeasurementUnits[1];
            DataContext = this;
            InitializeComponent();

        }

        private void OnAddM46(object sender, RoutedEventArgs e)
        {
            string type = "M4, 6mm";
            var dialog = new AddScrewWindow();
            dialog.DataContext = this;
            dialog.ShowDialog();
            double amountDouble = Convert.ToInt32(Amount);
            var screwType = Screws.Find(s => s.Type == type);
            var screw = new CartScrew(type);
            if (CurrentUnit == MeasurementUnits[0])
            {
                screw.Kg = amountDouble;
                var x = amountDouble / screwType.KgPer100;
                screw.Amount = x % 1 >= 0.5 ? (int)x + 1 : (int)x;
            }
            else
            {
                screw.Amount = (int)amountDouble;
            }
            screw.Price = screw.Amount * screwType.PricePer100;
            CartScrews.Add(screw);
        }
    }
}
