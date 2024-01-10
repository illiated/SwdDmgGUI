using System;
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

        SwdDmgFormula swdDmgFormula;
        public MainWindow()
        {
            InitializeComponent();
            swdDmgFormula = new SwdDmgFormula(randomRoll.Next(1, 7) + randomRoll.Next(1, 7) + randomRoll.Next(1, 7));

            DisplayDamage();
        }
        public void RollDice()
        {
            swdDmgFormula.Roll = randomRoll.Next(1, 7) + randomRoll.Next(1, 7) + randomRoll.Next(1, 7);
            DisplayDamage();
        }

        void DisplayDamage()
        {
            damage.Text = $"Rolled {swdDmgFormula.Roll} for {swdDmgFormula.Damage} HP"; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }
        private void Magic_Checked(object sender, RoutedEventArgs e)
        {
            swdDmgFormula.Magic = true;
            DisplayDamage();
        }
        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swdDmgFormula.Magic = false;
            DisplayDamage();
        }
        private void Flaming_Checked(object sender, RoutedEventArgs e)
        {
            swdDmgFormula.Flaming = true;
            DisplayDamage();
        }
        private void Flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swdDmgFormula.Flaming = false;
            DisplayDamage();
        }
    }
}