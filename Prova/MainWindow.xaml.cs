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
using System.Diagnostics;
using System.IO;

namespace Prova
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //CANVI DE PROVA 

           public MainWindow()
        {
            InitializeComponent();

            StackPanel elMeuPanellPrincipal = new StackPanel();
            elMeuPanellPrincipal.Orientation = Orientation.Horizontal;

            this.Content = elMeuPanellPrincipal;


            // Primer botó de prova 
            Button bt = new Button();
            bt.Width = 250;
            bt.Height = 50;
            bt.FontSize = 15;
            bt.Background = Brushes.DarkGray;
            bt.Margin = new Thickness(10);

            WrapPanel elMeuPanel = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "Hola";
            txt1.Foreground = Brushes.Red;
            elMeuPanel.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Adeu";
            txt2.Foreground = Brushes.Yellow;
            elMeuPanel.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Andreu";
            txt3.Foreground = Brushes.Green;
            elMeuPanel.Children.Add(txt3);

            bt.Content = elMeuPanel;

            elMeuPanellPrincipal.Children.Add(bt);


            // BOTÓ TIC TAC TOE
            Button btTicTacToe = new Button();

            btTicTacToe.Width = 150;
            btTicTacToe.Height = 150;
            btTicTacToe.FontSize = 18;
            btTicTacToe.Content = "Jugar a TicTacToe";
            btTicTacToe.Foreground = Brushes.White;
            btTicTacToe.Margin = new Thickness(10);

            ControlTemplate plantillaBoto = new ControlTemplate(typeof(Button));

            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.DarkBlue);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(75));

            FrameworkElementFactory contingut = new FrameworkElementFactory(typeof(ContentPresenter));
            contingut.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contingut.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);

            border.AppendChild(contingut);

            plantillaBoto.VisualTree = border;

            btTicTacToe.Template = plantillaBoto;
            btTicTacToe.Click += (sender, e) =>
            {
                string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"tictactoe.exe");

                Process.Start(new ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            };
            elMeuPanellPrincipal.Children.Add(btTicTacToe);
        }
    }
}