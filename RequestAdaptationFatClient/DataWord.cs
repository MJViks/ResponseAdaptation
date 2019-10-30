using System;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace RequestAdaptationFatClient
{
    class DataWord
    {
        //Процедура вывода чека
        public static void CheckDocument(string NomCheck, string Date, string Time, string[] Tovar, string[] Kolvo, string[] Cena, string SumBS, string SumSS)
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registr.DirPath + "Чек_" + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".docx";
            try
            {
                document.Sections.PageSetup.LeftMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registr.DocLM));
                document.Sections.PageSetup.RightMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registr.DocRM));
                document.Sections.PageSetup.TopMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registr.DocTM));
                document.Sections.PageSetup.BottomMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registr.DocBM));
                range.Text = "ООО 'CarFood'";
                range.ParagraphFormat.Alignment
                    = word.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "Чек";
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table Check = document.Tables.Add(pTable.Range, 7,
                    2);
                Check.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                Check.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                Check.Cell(1, 1).Range.Text = "Номер чека";
                Check.Cell(2, 1).Range.Text = "Дата";
                Check.Cell(3, 1).Range.Text = "Время";
                Check.Cell(4, 1).Range.Text = "Позиции";
                Check.Cell(5, 1).Range.Text = "Количество";
              
                Check.Cell(6, 1).Range.Text = "Сумма без скидки";
                Check.Cell(7, 1).Range.Text = "Сумма со скидкой";
                Check.Range.Font.Size = 11;
                Check.Range.Font.Name = "Times New Roman";
                Check.Columns[1].AutoFit();
                Check.Cell(1, 2).Range.Text = NomCheck;
                Check.Cell(2, 2).Range.Text = Date;
                Check.Cell(3, 2).Range.Text = Time;
                int i = 0;
                int fullCol = 0;
                Check.Cell(4, 2).Range.Text = "Товар   Цена         Кол-во \n";
                foreach (string tov in Tovar)
                {
                    Check.Cell(4, 2).Range.Text += tov + "   " + Cena[i] + " Руб.     " + Kolvo[i] + "   шт. \n";
                    fullCol += Convert.ToInt32(Kolvo[i]);
                    i++;
                }
                Check.Cell(5, 2).Range.Text = fullCol.ToString();

                Check.Cell(6, 2).Range.Text = SumBS;
                Check.Cell(7, 2).Range.Text = SumSS;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                application.Quit();
            }
        }
    }
}