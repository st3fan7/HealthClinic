using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using HealthClinic.Entiteti;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlIzdavanjeRecepta.xaml
    /// </summary>
    public partial class UserControlIzdavanjeRecepta : UserControl
    {
        public ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }

       
        public UserControlIzdavanjeRecepta()
        {
            InitializeComponent();
            this.DataContext = new Entiteti.Pacijenti();
            //Pacijenti = UserControlPocetna.Pacijenti;
            /*
            if(UserControlPregled.selectedPatient == null)
            {
                PacijentTextBox.Text = null;
            }
            else
            {
                PacijentTextBox.Text = UserControlPregled.selectedPatient.FullName;
                

                foreach(String lek in UserControlPregled.selectedPatient.Lekovi)
                {
                    LekoviPacijenta.Items.Add(lek);
                }

                foreach(String alergija in UserControlPregled.selectedPatient.Alergije)
                {
                    ListViewAlergije.Items.Add(alergija);
                }
                
            }
            */

            if (UserControlPocetna.userControlPocetna.ToolTipButto.IsChecked == true)
            {
                ToolTipService.SetIsEnabled(potvrda, true);
                ToolTipService.SetIsEnabled(odustani, true);
                

            }
            else
            {
                ToolTipService.SetIsEnabled(potvrda, false);
                ToolTipService.SetIsEnabled(odustani, false);
                
            }

        }

     
        private void ButtonPocetna_Click(object sender, RoutedEventArgs e)
        {
            
            (this.Parent as Grid).Children.Remove(this);
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Grid).Children.Remove(this);
        }

        private void Potvrda_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (UserControlPregled.selectedPatient != null)
            {
                UserControlPregled.selectedPatient.Lekovi.Add(LekText.Text);
            }
            */
        }


        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            bool found = false;
            var border = (resultStack.Parent as ScrollViewer).Parent as Border;
            var data = MainWindow.Lekovi.lekovi;

            string query = (sender as TextBox).Text;
            

            if (query.Length == 0)
            {
                // Clear   
                resultStack.Children.Clear();
                border.Visibility = Visibility.Collapsed;
            }
            else
            {
                border.Visibility = Visibility.Visible;
            }

           

            // Clear the list   
            resultStack.Children.Clear();

            // Add the result   
            foreach (var obj in data)
            {
                if (obj.Ime.ToLower().StartsWith(query.ToLower()))
                {
                    // The word starts with this... Autocomplete must work   
                    addItem(obj.Ime);
                    found = true;
                }
            }

            if (!found)
            {
                resultStack.Children.Add(new TextBlock() { Text = "Unesite svoj" });
            }
            */
        }


        private void addItem(string text)
        {
           
            TextBlock block = new TextBlock();
            var border = (resultStack.Parent as ScrollViewer).Parent as Border;
            // Add the text   
            block.Text = text;

            // A little style...   
            block.Margin = new Thickness(2, 3, 2, 3);
            block.Cursor = Cursors.Hand;

            // Mouse events   
            block.MouseLeftButtonUp += (sender, e) =>
            {
                LekText.Text = (sender as TextBlock).Text;
            };

            block.MouseEnter += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.PeachPuff;
            };

            block.MouseLeave += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.Transparent;
                border.Visibility = Visibility.Collapsed;
            };

            // Add to the panel   
            resultStack.Children.Add(block);
        }
    }


}
