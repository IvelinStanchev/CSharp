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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 1;
        public MainWindow()
        {
            InitializeComponent();
            StackPanel textInputStackPanel = new StackPanel();
            textInputStackPanel.KeyDown += new KeyEventHandler(OnTextInputKeyDown);
        }

        private void OnTextInputKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Left && e.Key != Key.Right && e.Key != Key.F12 &&
                e.Key != Key.F11 && e.Key != Key.F10 && e.Key != Key.F9 && 
                e.Key != Key.F8 && e.Key != Key.F7 && e.Key != Key.F6 &&
                e.Key != Key.F5 && e.Key != Key.F4 && e.Key != Key.F3 &&
                e.Key != Key.F2 && e.Key != Key.F1 && e.Key != Key.Tab &&
                e.Key != Key.CapsLock && e.Key != Key.LeftShift && e.Key != Key.RightShift &&
                e.Key != Key.LeftCtrl && e.Key != Key.RightCtrl && e.Key != Key.BrowserBack &&
                e.Key != Key.BrowserFavorites && e.Key != Key.BrowserForward && e.Key != Key.BrowserHome &&
                e.Key != Key.BrowserRefresh && e.Key != Key.BrowserSearch && e.Key != Key.BrowserStop &&
                e.Key != Key.Clear && e.Key != Key.PrintScreen && e.Key != Key.Scroll &&
                e.Key != Key.Pause && e.Key != Key.Insert && e.Key != Key.Home && 
                e.Key != Key.PageUp && e.Key != Key.PageDown && e.Key != Key.Delete &&
                e.Key != Key.End && e.Key != Key.Enter && e.Key != Key.Up &&
                e.Key != Key.Down && e.Key != Key.NumLock)
            {
                handle();
            }
        }

        private void OnTextInputButtonClick(object sender, RoutedEventArgs e)
        {
            handle();
            e.Handled = true;
        }

        public void handle()
        {
            CalculateSymbols();
        }

        private void CalculateSymbols()
        {
            counter = this.TextBox.Text.Length + 1;
            this.Symbols.Text = "Symbols: " + counter.ToString();
        }
    }
}
