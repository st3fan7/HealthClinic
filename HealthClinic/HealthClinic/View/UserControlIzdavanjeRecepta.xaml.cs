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
            this.DataContext = this;
            Pacijenti = UserControlPocetna.Pacijenti;
            if(UserControlPregled.selectedPatient == null)
            {
                PacijentTextBox.Text = null;
            }
            else
            {
                PacijentTextBox.Text = UserControlPregled.selectedPatient.FullName;
                ListViewAlergije.Items.Add(UserControlPregled.selectedPatient.Dijagnoza);
            }
            
            


        }

     
        private void ButtonPocetna_Click(object sender, RoutedEventArgs e)
        {

            /*//MainWindow._MainWindow.GridMain.Children.Clear();
            MainWindow._MainWindow.ItemPocetna.IsSelected = true;
            MainWindow._MainWindow.ItemPacijenti.IsSelected = false;
            MainWindow._MainWindow.ItemPregled.IsSelected = false;
            MainWindow._MainWindow.ItemValidacijaLeka.IsSelected = false;
            MainWindow._MainWindow.GridMain.Children.Add(new UserControlPocetna());
            //MainWindow._MainWindow.GridMain.Children.RemoveAt(MainWindow._MainWindow.GridMain.Children.Count - 1);
            */
            (this.Parent as Grid).Children.Remove(this);
        }
    }


}
