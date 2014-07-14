using System;
using System.Collections.Generic;
using System.Linq;
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

namespace NumberGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Data dataNumbers = new Data();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAddNewItemClick(object sender, RoutedEventArgs e)
        {
            var grid = new StackPanel();
            grid.HorizontalAlignment = HorizontalAlignment.Center;

            grid.Background = Brushes.LightGreen;
            var textBlock = new TextBlock();

            Random number = new Random();
            int chosenNumber = number.Next(1, 27);
            
            dataNumbers.AddNumber(chosenNumber);
            dataNumbers.WriteTheDataInAFile();

            textBlock.Text = chosenNumber.ToString();

            textBlock.FontSize = 150;
            textBlock.FontWeight = FontWeights.Bold;

            grid.Children.Add(textBlock);
            this.NumberGenerator.Children.Add(grid);
            
        }

        private void OnClearTheItemsClick(object sender, RoutedEventArgs e)
        {
            dataNumbers.ClearList();
            dataNumbers.ClearTheData();
        }
    }
}
