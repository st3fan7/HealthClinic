using HealthClinic.View.Dialogues;
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

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : UserControl
    {
        private List<String> datumiUNedelji = new List<String>();
        public Report()
        {
            InitializeComponent();
            datePickerSchedule.DisplayDateEnd = DateTime.Now;
            textWarning.Visibility = textWarningVisible;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridReport.Children.Clear();
            UserControl usc = new Home();
            GridReport.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridReport.Children.Clear();
            UserControl usc = new Home();
            GridReport.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridReport.Children.Clear();
            UserControl usc = new Schedule();
            GridReport.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridReport.Children.Clear();
            UserControl usc = new Patient();
            GridReport.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridReport.Children.Clear();
            UserControl usc = new Settings();
            GridReport.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (datePickerSchedule.SelectedDate != null)
            {
                datumiUNedelji.Clear();
                // RACUNANJE DATUMA POCETKA I KRAJA IZABRANJE NEDELJE
                DayOfWeek weekStart = DayOfWeek.Monday;
                DateTime startingDate = datePickerSchedule.SelectedDate.Value;

                while (startingDate.DayOfWeek != weekStart)
                    startingDate = startingDate.AddDays(-1);

                DateTime thisWeekStart = startingDate;
                String[] thisWeekStartParts = thisWeekStart.ToString().Split(' ');
                String monday = thisWeekStartParts[0];
                Console.WriteLine("PONDELJAK " + monday);
                datumiUNedelji.Add(monday);

                DateTime tuesdayDateTime = startingDate.AddDays(+1);
                String[] tuesdayParts = tuesdayDateTime.ToString().Split(' ');
                String tuesday = tuesdayParts[0];
                Console.WriteLine("UTORAK " + tuesday);
                datumiUNedelji.Add(tuesday);

                DateTime wednesdayDateTime = startingDate.AddDays(+2);
                String[] wednesdayParts = wednesdayDateTime.ToString().Split(' ');
                String wednesday = wednesdayParts[0];
                Console.WriteLine("SREDA " + wednesday);
                datumiUNedelji.Add(wednesday);

                DateTime thursdayDateTime = startingDate.AddDays(+3);
                String[] thursdayParts = thursdayDateTime.ToString().Split(' ');
                String thursday = thursdayParts[0];
                Console.WriteLine("CET " + thursday);
                datumiUNedelji.Add(thursday);

                DateTime fridayDateTime = startingDate.AddDays(+4);
                String[] fridayParts = fridayDateTime.ToString().Split(' ');
                String friday = fridayParts[0];
                Console.WriteLine("PETAK " + friday);
                datumiUNedelji.Add(friday);

                DateTime saturdayDateTime = startingDate.AddDays(+5);
                String[] saturdayParts = saturdayDateTime.ToString().Split(' ');
                String saturday = saturdayParts[0];
                Console.WriteLine("SUB " + saturday);
                datumiUNedelji.Add(saturday);

                DateTime thisWeekEnd = startingDate.AddDays(+6);
                String[] thisWeekEndParts = thisWeekEnd.ToString().Split(' ');
                String sunday = thisWeekEndParts[0];
                Console.WriteLine("NEDELJA " + sunday);
                datumiUNedelji.Add(sunday);

                // generisi izvestaj
                FlowDocument flowDocument = new FlowDocument();
                flowDocument.PagePadding = new System.Windows.Thickness(40,70,40,70);
                flowDocument.ColumnWidth = 1100;
                flowDocument.PageWidth = 900; //700;
                flowDocument.PageHeight = 1100;// 900;
                flowDocument.Background = Brushes.WhiteSmoke;

                //NASLOV
                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Horizontal;
                stackPanel.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                stackPanel.HorizontalAlignment = HorizontalAlignment.Center;
                
                TextBlock textBlock = new TextBlock();
                // textBlock.Text = "Nedeljni izveštaj o zakazanim operacijama i pregledima";
                textBlock.Inlines.Add(new Bold(new Run("Nedeljni izveštaj o zakazanim operacijama i pregledima")));
                textBlock.FontSize = 25;
                textBlock.HorizontalAlignment = HorizontalAlignment.Stretch;
                textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                textBlock.Margin = new System.Windows.Thickness(50, 0, 0, 0);
                textBlock.TextAlignment = TextAlignment.Center;
                stackPanel.Children.Add(textBlock);

                Paragraph top = new Paragraph();
                top.Inlines.Add(stackPanel);
                flowDocument.Blocks.Add(top);

                // PERIOD
                Paragraph periodOdDo = new Paragraph();
                periodOdDo.FontSize = 23;
                textBlock = new TextBlock();
                textBlock.Inlines.Add(new Underline(new Run("PERIOD")));
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                textBlock.Margin = new System.Windows.Thickness(365, 0, 0, 0);
                textBlock.TextAlignment = TextAlignment.Center;

                StackPanel zaPeriod = new StackPanel();
                zaPeriod.Orientation = Orientation.Horizontal;
                zaPeriod.VerticalAlignment = VerticalAlignment.Center;
                zaPeriod.Children.Add(textBlock);
                periodOdDo.Inlines.Add(zaPeriod);
                flowDocument.Blocks.Add(periodOdDo);



                // DATUM POCETKA I KRAJA NEDELJE
                Paragraph datumi = new Paragraph();
                datumi.FontSize = 23;
                textBlock = new TextBlock();
                textBlock.Text = monday + "  -  " + sunday;
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                textBlock.Margin = new System.Windows.Thickness(280, 0, 0, 0);
                textBlock.TextAlignment = TextAlignment.Center;

                StackPanel zaDatume= new StackPanel();
                zaDatume.Orientation = Orientation.Horizontal;
                zaDatume.VerticalAlignment = VerticalAlignment.Center;
                zaDatume.Children.Add(textBlock);
                datumi.Inlines.Add(zaDatume);
                flowDocument.Blocks.Add(datumi);

                // OPERACIJE
                Paragraph operacije = new Paragraph();
                operacije.FontSize = 23;
                textBlock = new TextBlock();
                textBlock.Inlines.Add(new Italic(new Run("OPERACIJE:")));
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                textBlock.Margin = new System.Windows.Thickness(345, 0, 0, 0);
                textBlock.TextAlignment = TextAlignment.Center;

                StackPanel zaOperacije = new StackPanel();
                zaOperacije.Orientation = Orientation.Horizontal;
                zaOperacije.VerticalAlignment = VerticalAlignment.Center;
                zaOperacije.Children.Add(textBlock);
                operacije.Inlines.Add(zaOperacije);
                flowDocument.Blocks.Add(operacije);


                Table table1 = new Table();
                table1.TextAlignment = TextAlignment.Center;
                table1.CellSpacing = 5;
                table1.Background = Brushes.LightGray;
                table1.BorderThickness = new Thickness(50, 0, 50, 0);

                int numberOfColumns = 5;

                for(int i = 1; i < numberOfColumns; i++)
                {
                    table1.Columns.Add(new TableColumn());
                }

                table1.RowGroups.Add(new TableRowGroup());
                table1.RowGroups[0].Rows.Add(new TableRow());
                TableRow currentRow = table1.RowGroups[0].Rows[0];
                currentRow.FontSize = 23;
                currentRow.FontWeight = FontWeights.Bold;
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Datum"))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Vreme"))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Sala"))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Lekar"))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Pacijent"))));
                table1.RowGroups[0].Rows.Add(new TableRow());


                int j = 1;

                //foreach(String datum in datumiUNedelji)
                //{
                //    foreach(Termin termin in Loading.termini)
                //    {
                //        if(termin.Datum.Equals(datum) && termin.Status.Equals("Zauzet") && termin.Zadatak.Equals("Operacija"))
                //        {
                //            table1.RowGroups[0].Rows[j].FontSize = 20;
                //            table1.RowGroups[0].Rows[j].FontWeight = FontWeights.Normal;
                //            table1.RowGroups[0].Rows.Add(new TableRow());
                //            table1.RowGroups[0].Rows[j].Cells.Add(new TableCell(new Paragraph(new Run(termin.Datum.ToString())))); //, termin.Vreme.ToString(), termin.Sala.ToString() , termin.Lekar.ToString() , termin.Pacijent.ToString()
                //            table1.RowGroups[0].Rows[j].Cells.Add(new TableCell(new Paragraph(new Run(termin.Vreme.ToString()))));
                //            table1.RowGroups[0].Rows[j].Cells.Add(new TableCell(new Paragraph(new Run(termin.Sala.ToString()))));
                //            table1.RowGroups[0].Rows[j].Cells.Add(new TableCell(new Paragraph(new Run(termin.Lekar.ToString()))));
                //            table1.RowGroups[0].Rows[j].Cells.Add(new TableCell(new Paragraph(new Run(termin.Pacijent.ToString()))));
                //            j++;
                //        }
                //    }
                //}

                flowDocument.Blocks.Add(table1);



                // PREGLEDI
                Paragraph pregledi = new Paragraph();
                pregledi.FontSize = 23;
                textBlock = new TextBlock();
                textBlock.Inlines.Add(new Italic(new Run("PREGLEDI:")));
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                textBlock.Margin = new System.Windows.Thickness(345, 0, 0, 0);
                textBlock.TextAlignment = TextAlignment.Center;

                StackPanel zaPrelgede = new StackPanel();
                zaPrelgede.Orientation = Orientation.Horizontal;
                zaPrelgede.VerticalAlignment = VerticalAlignment.Center;
                zaPrelgede.Children.Add(textBlock);
                pregledi.Inlines.Add(zaPrelgede);
                flowDocument.Blocks.Add(pregledi);


                Table table2 = new Table();
                table2.TextAlignment = TextAlignment.Center;
                table2.CellSpacing = 5;
                table2.Background = Brushes.LightGray;
                table2.BorderThickness = new Thickness(50, 0, 50, 0);

                int numberOfColumnsForExamination = 5;

                for (int i = 1; i < numberOfColumnsForExamination; i++)
                {
                    table2.Columns.Add(new TableColumn());
                }

                table2.RowGroups.Add(new TableRowGroup());
                table2.RowGroups[0].Rows.Add(new TableRow());
                TableRow currentRow2 = table2.RowGroups[0].Rows[0];
                currentRow2.FontSize = 23;
                currentRow2.FontWeight = FontWeights.Bold;
                currentRow2.Cells.Add(new TableCell(new Paragraph(new Run("Datum"))));
                currentRow2.Cells.Add(new TableCell(new Paragraph(new Run("Vreme"))));
                currentRow2.Cells.Add(new TableCell(new Paragraph(new Run("Sala"))));
                currentRow2.Cells.Add(new TableCell(new Paragraph(new Run("Lekar"))));
                currentRow2.Cells.Add(new TableCell(new Paragraph(new Run("Pacijent"))));
                table2.RowGroups[0].Rows.Add(new TableRow());


                int j2 = 1;

                //foreach (String datum in datumiUNedelji)
                //{
                //    foreach (Termin termin in Loading.termini)
                //    {
                //        if (termin.Datum.Equals(datum) && termin.Status.Equals("Zauzet") && termin.Zadatak.Equals("Pregled"))
                //        {
                //            table2.RowGroups[0].Rows[j2].FontSize = 20;
                //            table2.RowGroups[0].Rows[j2].FontWeight = FontWeights.Normal;
                //            table2.RowGroups[0].Rows.Add(new TableRow());
                //            table2.RowGroups[0].Rows[j2].Cells.Add(new TableCell(new Paragraph(new Run(termin.Datum.ToString()))));
                //            table2.RowGroups[0].Rows[j2].Cells.Add(new TableCell(new Paragraph(new Run(termin.Vreme.ToString()))));
                //            table2.RowGroups[0].Rows[j2].Cells.Add(new TableCell(new Paragraph(new Run(termin.Sala.ToString()))));
                //            table2.RowGroups[0].Rows[j2].Cells.Add(new TableCell(new Paragraph(new Run(termin.Lekar.ToString()))));
                //            table2.RowGroups[0].Rows[j2].Cells.Add(new TableCell(new Paragraph(new Run(termin.Pacijent.ToString()))));
                //            j2++;
                //        }
                //    }
                //}

                flowDocument.Blocks.Add(table2);

                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintDocument(((IDocumentPaginatorSource)flowDocument).DocumentPaginator, "");
                }


            }
            else
            {
                textWarning.Visibility = textWarningHidden;

            }
        }

        private Visibility textWarningHidden
        {
            get { return Visibility.Visible; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Hidden; }
        }

        private void datePickerSchedule_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datePickerSchedule.SelectedDate != null)
            {

                textWarning.Visibility = textWarningVisible;
            }
            else
            {
                textWarning.Visibility = textWarningHidden;
            }

        }
    }
}
