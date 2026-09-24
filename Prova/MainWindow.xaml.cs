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

namespace Prova
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid elMeuGrid = new Grid();
            this.Content = elMeuGrid;

            Button bt = new Button();
            bt.Width = 75;
            bt.Height = 200;
            bt.FontSize = 15;
            bt.Background = Brushes.DarkGray;
            WrapPanel elMeuPanel = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "Hola";
            txt1.Foreground = Brushes.Orange;
            elMeuPanel.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Adeu";
            txt2.Foreground = Brushes.Green;
            elMeuPanel.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Andreu";
            txt3.Foreground = Brushes.Pink;
            elMeuPanel.Children.Add(txt3);

            bt.Content = elMeuPanel;

            elMeuGrid.Children.Add(bt);
        }
    }
}
