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

namespace SwdDmgGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomRoll = new Random();
        public MainWindow()
        {
            InitializeComponent();
            SwdDmgFormula swdDmg = new SwdDmgFormula(randomRoll.Next(1, 7) + randomRoll.Next(1, 7) + randomRoll.Next(1, 7));// cont page 267
        }
    }
}