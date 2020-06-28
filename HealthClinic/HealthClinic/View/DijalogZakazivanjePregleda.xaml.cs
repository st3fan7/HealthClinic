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
using System.Windows.Shapes;
using Controller.RoomsControlers;
using Controller.UsersControlers;
using HealthClinic.Entiteti;
using Model.AllActors;
using Model.Term;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for DijalogZakazivanjePregleda.xaml
    /// </summary>
    public partial class DijalogZakazivanjePregleda : Window
    {
        //Pacijent pacijent = new Pacijent();


        private bool hitnost = false;
        private Room room = null;
        private readonly RoomController roomController;
        private static WorkingTimeForDoctor workingTimeForDoctor = null;
        private static WorkingTimeForDoctorController workingTimeForDoctorController;
        
        public DijalogZakazivanjePregleda()
        {
            InitializeComponent();
            

            //Vremena();
            

            /*
            if (UserControlPregled.selectedPatient == null)
            {
                Ime.Text = null;
                Prezime.Text = null;
                pacijent.ProsliPregled = "";
                pacijent.Lekovi = new ObservableCollection<string>();
                pacijent.Alergije = new ObservableCollection<string>();
                pacijent.Simptomi = new ObservableCollection<string>();
                pacijent.Dijagnoza = "";



            }
            else
            {
                pacijent = UserControlPregled.selectedPatient;
                
                
                Ime.Text = UserControlPregled.selectedPatient.Ime;
                Prezime.Text = UserControlPregled.selectedPatient.Prezime;             
                pacijent.ProsliPregled = UserControlPregled.selectedPatient.Datum;
                pacijent.Dijagnoza = UserControlPregled.selectedPatient.Dijagnoza;
                

            }
            */

            if (UserControlPocetna.MedicalExamination != null)
            {
                Ime.Text = UserControlPocetna.MedicalExamination.Patient.Name;
                Prezime.Text = UserControlPocetna.MedicalExamination.Patient.Surname;
            }
            else
            {
                Ime.Text = "";
                Prezime.Text = "";
            }



            var app = App.Current as App;
            roomController = app.RoomController;
            workingTimeForDoctorController = app.WorkingTimeForDoctorController;

            foreach (Room room in roomController.GetAllEntities())
            {
               
                if(room.TypeOfRoom.NameOfType.Equals("Soba za preglede"))
                {
                    Sala.Items.Add(room.RoomID);
                }

            }

   

            /*
            Sala.Items.Add("1001");
            Sala.Items.Add("20B");
            Sala.Items.Add("30A");
            */




        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //pacijent.KratakProblem = Razlog.Text.ToString();
        }

       
        public void Vremena()
        {
            for(int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j+=30)
                {
                    
                    if(i < 10 && j < 10)
                    {
                        ListVremena.Items.Add("0" + i + ":0" + j);
                        ListVremenaKraj.Items.Add("0" + i + ":0" + j);
                    }else if(i < 10 && j > 10)
                    {
                        ListVremena.Items.Add("0" + i + ":" + j);
                        ListVremenaKraj.Items.Add("0" + i + ":" + j);
                    }
                    else if (i >= 10 && j < 10)
                    {
                        ListVremena.Items.Add(i + ":0" + j);
                        ListVremenaKraj.Items.Add(i + ":0" + j);
                    }
                    else if (i >= 10 && j > 10)
                    {
                        ListVremena.Items.Add(i + ":" + j);
                        ListVremenaKraj.Items.Add(i + ":" + j);
                    }
                    
                    /*
                    ListVremena.Items.Add(i + ":" + j);
                    ListVremenaKraj.Items.Add(i + ":" + j);
                    */


                }
            }

            int pocetni = 0;
            int krajnji = 0;
            if (UserControlPocetna.MedicalExamination != null)
            {          

                for(int i = 0; i < ListVremena.Items.Count; i++)
                {
                  //ISPRAVI
                   
                    if (UserControlPocetna.MedicalExamination.FromDateTime.ToString("HH:mm").Equals(ListVremena.Items.GetItemAt(i)))
                    {
                        pocetni = i;
                       // break;
                    }

                    if (UserControlPocetna.MedicalExamination.ToDateTime.ToString("HH:mm").Equals(ListVremena.Items.GetItemAt(i)))
                    {
                        krajnji = i;
                        //break;
                    }

                    
                    //Console.WriteLine(ListVremena.Items.GetItemAt(i) + " " + i);

                    

                }
             
            }

            /*
            for(int a = pocetni+1; a <= krajnji; a++)
            {
                Console.WriteLine(ListVremena.Items.GetItemAt(a));
                ListVremena.Items.Remove(ListVremena.Items.GetItemAt(a));
            }
            */
            /*
            for (int a = pocetni; a <= krajnji; a++)
            {
                Console.WriteLine(ListVremena.Items.GetItemAt(a));
                ListVremena.Items.RemoveAt(a);
            }
            */

        }

        private void DaChecked_Checked(object sender, RoutedEventArgs e)
        {
            if (DaChecked.IsChecked == true)
            {
                // pacijent.Hitnost = "Da";
                //UserControlPocetna.MedicalExamination.Urgency = true;
                hitnost = true;
                NeChecked.IsChecked = false;
                NeChecked.IsEnabled = false;
            }
        }

        private void DaChecked_Unchecked(object sender, RoutedEventArgs e)
        {
            if (DaChecked.IsChecked == false)
            {
                // NeChecked.IsChecked = false;
                NeChecked.IsEnabled = true;
            }
        }

        private void NeChecked_Checked(object sender, RoutedEventArgs e)
        {
            if (NeChecked.IsChecked == true)
            {
                // pacijent.Hitnost = "Ne";
                //UserControlPocetna.MedicalExamination.Urgency = false;
                hitnost = false;
                DaChecked.IsChecked = false;
                DaChecked.IsEnabled = false;
            }
        }

        private void NeChecked_Unchecked(object sender, RoutedEventArgs e)
        {
            if (NeChecked.IsChecked == false)
            {
                // NeChecked.IsChecked = false;
                DaChecked.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*
            pacijent.Ime = Ime.Text;
            pacijent.Prezime = Prezime.Text;
            pacijent.Datum = datePicker.SelectedDate.Value.ToString("dd.MM.yyyy");
            pacijent.Vreme = ListVremena.SelectedItem.ToString();
            pacijent.Sala = Sala.SelectedItem.ToString();
            pacijent.Zadatak = "Pregled";
           

            pacijent.KratakProblem = Razlog.Text;
           

            */

            foreach(Room r in roomController.GetAllEntities())
            {
                if (Sala.SelectedItem.Equals(r.RoomID))
                {
                    room = roomController.GetEntity(r.GetId());

                }
            }

            String datum = datePicker.SelectedDate.Value.ToString("dd.MM.yyyy.");
            String vremePocetka = ListVremena.SelectedItem.ToString();
            String vremeKraja = ListVremenaKraj.SelectedItem.ToString();






            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da ste dobro uneli podatke?\nAko jeste, potvrdite.", "Zakazivanje pregleda", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                UserControlPocetna.MedicalExamination.Urgency = hitnost;
                UserControlPocetna.MedicalExamination.ShortDescription = Razlog.Text;
                UserControlPocetna.MedicalExamination.Room = room;
                UserControlPocetna.MedicalExamination.FromDateTime = DateTime.Parse(datum + " " + vremePocetka);
                UserControlPocetna.MedicalExamination.ToDateTime = DateTime.Parse(datum + " " + vremeKraja);

                UserControlPocetna.medicalExaminationController.UpdateEntity(UserControlPocetna.MedicalExamination);
                UserControlPocetna.userControlPocetna.dgrMain.Items.Refresh();
                UserControlPocetna.userControlPocetna.dgrMain.UpdateLayout();






                /*
                if (UserControlPregled.selectedPatient == null)
                {
                    MainWindow.Pacijenti.dodajPacijenta(pacijent);
                }
                else
                {
                    UserControlPregled.selectedPatient = pacijent;
                }
                */
                this.Close();
            }
        }

        /*
        private List<String> terminiLekara()
        {
            if(workingTimeForDoctor != null)
            {
                String[] parts = workingTimeForDoctor.FromDateTime.ToString().Split(' ');
                Console.WriteLine(parts[1]);
            }
            else
            {
                
            }
            
            return null;
        }
        */

        private List<MedicalExamination> getAllMedExByDate(DayOfWeek day, Doctor doctor)
        {
            List<MedicalExamination> lista = new List<MedicalExamination>();
            foreach (MedicalExamination m in UserControlPocetna.medicalExaminationController.GetAllEntities())
            {
                if (m.FromDateTime.DayOfWeek.ToString().Equals(day.ToString()) && (m.Doctor.GetId() == doctor.GetId()))
                {
                    lista.Add(m);
                }
            }
            return lista;
        }
        

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            workingTimeForDoctor = workingTimeForDoctorController.GetWorkTimeForDoctorByDoctorAndDay(Window1.ulogovaniDoctor, datePicker.SelectedDate.Value.DayOfWeek);
            //Console.WriteLine(workingTimeForDoctor.FromDateTime + " " + workingTimeForDoctor.Doctor.Name);
            List<MedicalExamination> medicalExaminations = this.getAllMedExByDate(workingTimeForDoctor.FromDateTime.DayOfWeek, Window1.ulogovaniDoctor);
           
            List<int> timesStart = new List<int>();

            foreach(MedicalExamination m in medicalExaminations)
            {
               
               // Console.WriteLine(m.FromDateTime.DayOfWeek.ToString() + " " + m.Patient.Name);
                String[] partss = m.FromDateTime.ToString().Split(' ');
                //Console.WriteLine(parts[1]);
                String[] starTimePartss = partss[1].Split(':'); //08
                int starts;
                starts = int.Parse(starTimePartss[0]);
                timesStart.Add(starts);
            }

            List<int> timesEnd = new List<int>();

            foreach (MedicalExamination m in medicalExaminations)
            {
                //Console.WriteLine(m.FromDateTime + " " + m.Patient.Name);
                String[] partss = m.ToDateTime.ToString().Split(' ');
                //Console.WriteLine(parts[1]);
                String[] starTimePartss = partss[1].Split(':'); //08
                int starts;
                starts = int.Parse(starTimePartss[0]);
                timesEnd.Add(starts);
            }

         

            String[] parts = workingTimeForDoctor.FromDateTime.ToString().Split(' ');
            //Console.WriteLine(parts[1]);
            String[] starTimeParts = parts[1].Split(':'); //08
            int start;
            start = int.Parse(starTimeParts[0]);
            //Console.WriteLine(start);
            String[] endParts = workingTimeForDoctor.ToDateTime.ToString().Split(' ');
            String[] endTimeParts = endParts[1].Split(':');
            int end;
            end = int.Parse(endTimeParts[0]);

            ListVremena.Items.Clear();
            ListVremenaKraj.Items.Clear();

            

            if (start < end) 
            {
                for (int i = start; i < end; i++)
                {
                    //foreach (int startE in timesStart)
                    //{
                      //  foreach(int endE in timesEnd)
                       // {
                         //   if (i < startE || i > endE)
                           // {
                                for (int j = 0; j < 60; j += 30)
                                {

                                    if (i < 10 && j < 10)
                                    {
                                        ListVremena.Items.Add("0" + i + ":0" + j);
                                        ListVremenaKraj.Items.Add("0" + i + ":0" + j);
                                    }
                                    else if (i < 10 && j > 10)
                                    {
                                        ListVremena.Items.Add("0" + i + ":" + j);
                                        ListVremenaKraj.Items.Add("0" + i + ":" + j);
                                    }
                                    else if (i >= 10 && j < 10)
                                    {
                                        ListVremena.Items.Add(i + ":0" + j);
                                        ListVremenaKraj.Items.Add(i + ":0" + j);
                                    }
                                    else if (i >= 10 && j > 10)
                                    {
                                        ListVremena.Items.Add(i + ":" + j);
                                        ListVremenaKraj.Items.Add(i + ":" + j);
                                    }
                                }
                            //}
                        //}
                        
                    //}
                    
                }
            }else if(start > end)
            {

                for (int i = start; i > end; i--)
                {
                    for (int j = 0; j < 60; j += 30)
                    {

                        if (i < 10 && j < 10)
                        {
                            ListVremena.Items.Add("0" + i + ":0" + j);
                            ListVremenaKraj.Items.Add("0" + i + ":0" + j);
                        }
                        else if (i < 10 && j > 10)
                        {
                            ListVremena.Items.Add("0" + i + ":" + j);
                            ListVremenaKraj.Items.Add("0" + i + ":" + j);
                        }
                        else if (i >= 10 && j < 10)
                        {
                            ListVremena.Items.Add(i + ":0" + j);
                            ListVremenaKraj.Items.Add(i + ":0" + j);
                        }
                        else if (i >= 10 && j > 10)
                        {
                            ListVremena.Items.Add(i + ":" + j);
                            ListVremenaKraj.Items.Add(i + ":" + j);
                        }
                    }
                }

            }

            



        }
    }
}
