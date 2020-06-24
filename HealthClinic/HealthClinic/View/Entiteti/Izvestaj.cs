using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace HealthClinic.Entiteti
{
    public class Izvestaj
    {

     
        public Izvestaj(Pacijent pacijent)
        {

            FlowDocument flowDocument = new FlowDocument();
            flowDocument.PagePadding = new System.Windows.Thickness(50);
            flowDocument.ColumnWidth = 1000;
            flowDocument.PageWidth = 700;
            flowDocument.PageHeight = 900;
            flowDocument.Background = Brushes.WhiteSmoke;


            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            


            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Izveštaj trenutnog pregleda za anamnezu i lekove";
            textBlock.FontSize = 27;
            textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            textBlock.Margin = new System.Windows.Thickness(5, 0, 5, 50);
            stackPanel.Children.Add(textBlock);

            Paragraph top = new Paragraph();
            top.Inlines.Add(stackPanel);
            flowDocument.Blocks.Add(top);
            //---DODAO NASLOV---


            Paragraph imePacijenta = new Paragraph();
            imePacijenta.FontSize = 20;
            textBlock = new TextBlock();
            textBlock.Text = "Pacijent: ";
            TextBlock tb = new TextBlock();
            tb.Text = pacijent.FullName;
            textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            textBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;

            StackPanel zaIme = new StackPanel();
            zaIme.Orientation = Orientation.Horizontal;
            zaIme.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            zaIme.Children.Add(textBlock);
            zaIme.Children.Add(tb);
            imePacijenta.Inlines.Add(zaIme);
            flowDocument.Blocks.Add(imePacijenta);
            //---DODAO PACIJENTA---


            Paragraph datum = new Paragraph();
            datum.FontSize = 20;
            textBlock = new TextBlock();
            textBlock.Text = "Datum pregleda: ";
            tb = new TextBlock();
            tb.Text = pacijent.Datum;
            textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            textBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Left ;

            StackPanel zaDatum = new StackPanel();
            zaDatum.Orientation = Orientation.Horizontal;
            zaDatum.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            zaDatum.Children.Add(textBlock);
            zaDatum.Children.Add(tb);         
            datum.Inlines.Add(zaDatum);
            flowDocument.Blocks.Add(datum);
            //---DODAO DATUM--




            Paragraph vreme = new Paragraph();
            vreme.FontSize = 20;
            textBlock = new TextBlock();
            textBlock.Text = "Vreme pregleda: ";
            tb = new TextBlock();
            tb.Text = pacijent.Vreme;
            textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            textBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBlock.Margin = new System.Windows.Thickness(0, 0, 0, 30);

            StackPanel zaVreme = new StackPanel();
            zaVreme.Orientation = Orientation.Horizontal;
            zaVreme.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            zaVreme.Children.Add(textBlock);
            zaVreme.Children.Add(tb);
            vreme.Inlines.Add(zaVreme);
            flowDocument.Blocks.Add(vreme);
            //--DODAO VREME---




            Paragraph anamneza = new Paragraph();
            anamneza.FontSize = 20;
            textBlock = new TextBlock();
            textBlock.Text = "Anamneza: ";
            textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            textBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            StackPanel zaAnamenezu = new StackPanel();
            zaAnamenezu.Orientation = Orientation.Horizontal;
            zaAnamenezu.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            zaAnamenezu.Margin = new System.Windows.Thickness(0, 0, -50, 0);
            zaAnamenezu.Children.Add(textBlock);
            anamneza.Inlines.Add(zaAnamenezu);
            flowDocument.Blocks.Add(anamneza);

            Paragraph anamnezaTekst = new Paragraph();
            anamnezaTekst.FontSize = 19;
            tb = new TextBlock();
            tb.Text = pacijent.Anamenza;
            tb.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            tb.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            tb.TextWrapping = System.Windows.TextWrapping.WrapWithOverflow;
            StackPanel anamneza2 = new StackPanel();
            anamneza2.Orientation = Orientation.Horizontal;
            anamneza2.Orientation = Orientation.Vertical;
            anamneza2.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            anamneza2.Margin = new System.Windows.Thickness(0, 0, 10, 0);
            anamneza2.Children.Add(tb);
            anamnezaTekst.Inlines.Add(anamneza2);
            flowDocument.Blocks.Add(anamnezaTekst);
            //--ANAMNEZA

            Paragraph lekText = new Paragraph();
            lekText.FontSize = 20;
            textBlock = new TextBlock();
            textBlock.Text = "Lekovi: ";
            textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            textBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            StackPanel zaLekText = new StackPanel();
            zaLekText.Orientation = Orientation.Horizontal;
            zaLekText.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            zaLekText.Margin = new System.Windows.Thickness(0, 0, -10, 0);
            zaLekText.Children.Add(textBlock);
            lekText.Inlines.Add(zaLekText);
            flowDocument.Blocks.Add(lekText);
            //lek tekst




            Table table1 = new Table();
            table1.CellSpacing = 10;
            table1.Background = Brushes.White;
            int numberOfColumns = 2;

            for(int i = 0; i < numberOfColumns; i++)
            {
                table1.Columns.Add(new TableColumn());
            }

            table1.RowGroups.Add(new TableRowGroup());
            table1.RowGroups[0].Rows.Add(new TableRow());
            TableRow currentRow = table1.RowGroups[0].Rows[0];
            currentRow.FontSize = 24;
            currentRow.FontWeight = System.Windows.FontWeights.Bold;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Lekovi tokom pregleda"))));
            currentRow.Cells[0].ColumnSpan = 2;
            table1.RowGroups[0].Rows.Add(new TableRow());
            currentRow = table1.RowGroups[0].Rows[1];
            currentRow.FontSize = 18;
            currentRow.FontWeight = FontWeights.Bold;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Naziv leka"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Proizvođač"))));        
            table1.RowGroups[0].Rows.Add(new TableRow());
            currentRow = table1.RowGroups[0].Rows[2];

            
            currentRow.FontSize = 18;
            currentRow.FontWeight = FontWeights.Normal;

            int j = 2;
            for (int i = 0; i < pacijent.Lekovi.Count; i++)
            {
                table1.RowGroups[0].Rows.Add(new TableRow());
                table1.RowGroups[0].Rows[j].Cells.Add(new TableCell(new Paragraph(new Run(pacijent.Lekovi[i].ToString()))));          
                j++;
            }
            
            flowDocument.Blocks.Add(table1);
            //--LEKOVI








            PrintDialog printDialog = new PrintDialog();
            if(printDialog.ShowDialog() == true)
            {
                printDialog.PrintDocument(((IDocumentPaginatorSource)flowDocument).DocumentPaginator, "");
            }



        }

        

    }
}
