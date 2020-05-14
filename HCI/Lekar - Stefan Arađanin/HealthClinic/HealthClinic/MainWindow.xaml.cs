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

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _MainWindow = this;
            ItemPocetna.IsSelected = true;
            

        }

        public static MainWindow _MainWindow = new MainWindow();

        public static UserControl usc = null;

        private void ScrollViewer_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void ButtonCloseTB_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenTB.Visibility = Visibility.Visible;
            ButtonCloseTB.Visibility = Visibility.Collapsed;
            
        }

        private void ButtonOpenTB_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenTB.Visibility = Visibility.Collapsed;
            ButtonCloseTB.Visibility = Visibility.Visible;

        }

        private void AddPresetButton_Click(object sender, RoutedEventArgs e)
        {
            var addButton = sender as FrameworkElement;
            if (addButton != null)
            {
                addButton.ContextMenu.IsOpen = true;
            }
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemPocetna":
                    usc = new UserControlPocetna();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemPregled":
                    usc = new UserControlPregled();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemPacijenti":
                    usc = new UserControlPacijenti();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemOdjava":
                    var LogOut = new Window1();
                    LogOut.Show();
                    this.Hide();
                                    
                    break;
                    
                
                default:
                    break;
            }
        }

        private void MenuPocetna_Click(object sender, RoutedEventArgs e)
        {
            UserControl uscP = new UserControlPocetna();
            if(usc != uscP)
            {
                GridMain.Children.Clear();             
                GridMain.Children.Add(uscP);

            }

           
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void MenuPregled_Click(object sender, RoutedEventArgs e)
        {
            UserControl uscPr = new UserControlPregled();
            if (usc != uscPr)
            {
                GridMain.Children.Clear();
                ItemPregled.IsSelected = true;
                ItemPocetna.IsSelected = false;
                ItemPacijenti.IsSelected = false;
                GridMain.Children.Add(uscPr);

            }

        }

        private void MenuPacijenti_Click(object sender, RoutedEventArgs e)
        {
            UserControl uscPa = new UserControlPacijenti();
            if (usc != uscPa)
            {
                GridMain.Children.Clear();
                ItemPacijenti.IsSelected = true;
                ItemPregled.IsSelected = false;
                ItemPocetna.IsSelected = false;
                GridMain.Children.Add(uscPa);

            }

        }
    }
}
