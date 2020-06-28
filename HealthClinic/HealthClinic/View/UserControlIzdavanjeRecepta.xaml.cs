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
using Controller.MedicamentControlers;
using HealthClinic.Entiteti;
using Model.Doctor;
using Model.DoctorMenager;
using Model.PatientDoctor;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlIzdavanjeRecepta.xaml
    /// </summary>
    public partial class UserControlIzdavanjeRecepta : UserControl
    {
        /*
        public ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }
        */

        public static IssueOfMedicaments issueOfMedicaments = null;
        public static IssueMedicamentsController issueMedicamentsController;
        public static MedicamentController medicamentController;
        public static Medicament medicament = null;

       
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

            var app = Application.Current as App;
            issueMedicamentsController = app.IssueOfMedicamentsController;
            medicamentController = app.MedicamentController;


            if (UserControlPregled.medicalRecord != null)
            {
                Console.WriteLine(UserControlPregled.medicalRecord.Patient.Name);
                foreach(IssueOfMedicaments i in issueMedicamentsController.GetAllEntities())
                {
                    if(i.MedicalRecord.GetId() == UserControlPregled.medicalRecord.GetId())
                    {
                        issueOfMedicaments = issueMedicamentsController.GetEntity(i.GetId());
                    }
                    else
                    {
                        issueOfMedicaments = new IssueOfMedicaments();
                    }
                    
                }

                PacijentTextBox.Text = UserControlPregled.medicalRecord.Patient.Name + " " + UserControlPregled.medicalRecord.Patient.Surname;

                foreach (Medicament m in UserControlPregled.medicalRecord.Medicament)
                {
                    LekoviPacijenta.Items.Add(m);
                    LekoviPacijenta.DisplayMemberPath = "Name";
                }

                foreach (Allergies alergija in UserControlPregled.medicalRecord.Allergies)
                {
                    ListViewAlergije.Items.Add(alergija);
                    ListViewAlergije.DisplayMemberPath = "Name";

                }


                

            }



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

            foreach(Medicament m in medicamentController.GetComfirmedMedicaments())
            {
                if (m.Name.Equals(LekText.Text))
                {
                    medicament = m;
                }
            }

            List<Medicament> listaLekova = new List<Medicament>();
            listaLekova.Add(medicament);
            issueMedicamentsController.AddEntity(new IssueOfMedicaments(ReceptText.Text, UserControlPregled.medicalRecord, Window1.ulogovaniDoctor, listaLekova));



        }


        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
            bool found = false;
            var border = (resultStack.Parent as ScrollViewer).Parent as Border;            
            var data = medicamentController.GetComfirmedMedicaments();

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
                if (obj.Name.ToLower().StartsWith(query.ToLower()))
                {
                    // The word starts with this... Autocomplete must work   
                    addItem(obj.Name);
                    found = true;
                }
            }

            if (!found)
            {
                resultStack.Children.Add(new TextBlock() { Text = "Unesite svoj" });
            }
            
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
