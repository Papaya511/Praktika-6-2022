using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            Model1 m = new Model1();
            var query =
            from Worker in m.Workers
            select new { Worker.id_worker, Worker.name_worker, Worker.surname_worker, Worker.patronymic, Worker.age, Worker.family_status, Worker.gender, Worker.id_post, Worker.id_history, Worker.id_category };

            WorkersTable.ItemsSource = query.ToList();

            var q =
              from Category in m.Category
              select new { Category.id_category, Category.category1,Category.id_post,Category.factor };
            CaregoryTable.ItemsSource = q.ToList();
        }

        private void W_upd_b_Click(object sender, RoutedEventArgs e)
        {
            update_1 w = new update_1();
            w.Show();
        }

        private void C_upd_b_Click(object sender, RoutedEventArgs e)
        {
            update_2 w = new update_2();
            w.Show();

        }

        private void W_add_b_Click(object sender, RoutedEventArgs e)
        {
            add_1 w = new add_1();
            w.Show();
        }

        private void C_add_b_Click(object sender, RoutedEventArgs e)
        {
            add_2 w = new add_2();
            w.Show();
        }

        private void C_del_b_Click(object sender, RoutedEventArgs e)
        {
            delete_2 w = new delete_2();
            w.Show();
        }

        private void W_del_b_Click(object sender, RoutedEventArgs e)
        {
            delete_1 w = new delete_1();
            w.Show();
        }

        private void W_export_b_Click(object sender, RoutedEventArgs e)
        {
            List<Workers> workers;

            using (Model1 model1Entities = new Model1())
            {
                workers = model1Entities.Workers.ToList().OrderBy(s => s.name_worker).ToList();
                var app = new Word.Application();
                Word.Document document = app.Documents.Add();

                Word.Paragraph paragraph =
                document.Paragraphs.Add();
                Word.Range range = paragraph.Range;
                range.Text = "";
                paragraph.set_Style("Заголовок 1");
                range.InsertParagraphAfter();
                Word.Paragraph tableParagraph = document.Paragraphs.Add();
                Word.Range tableRange = tableParagraph.Range;
                Word.Table studentsTable =
                document.Tables.Add(tableRange, workers.Count() + 1, 10);
                studentsTable.Borders.InsideLineStyle =
                studentsTable.Borders.OutsideLineStyle =
                Word.WdLineStyle.wdLineStyleSingle;
                studentsTable.Range.Cells.VerticalAlignment =
                Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                Word.Range cellRange;
                cellRange = studentsTable.Cell(1, 1).Range;
                cellRange.Text = "ИД";
                cellRange = studentsTable.Cell(1, 2).Range;
                cellRange.Text = "Имя";
                cellRange = studentsTable.Cell(1, 3).Range;
                cellRange.Text = "Фамилия";
                cellRange = studentsTable.Cell(1, 4).Range;
                cellRange.Text = "Отчество";
                cellRange = studentsTable.Cell(1, 5).Range;
                cellRange.Text = "Возраст";
                cellRange = studentsTable.Cell(1, 6).Range;
                cellRange.Text = "Семейное положение";
                cellRange = studentsTable.Cell(1, 7).Range;
                cellRange.Text = "Пол";
                cellRange = studentsTable.Cell(1, 8).Range;
                cellRange.Text = "ИД_почты";
                cellRange = studentsTable.Cell(1, 9).Range;
                cellRange.Text = "ИД_истории";
                cellRange = studentsTable.Cell(1, 10).Range;
                cellRange.Text = "ИД_категории";
                studentsTable.Rows[1].Range.Bold = 1;
                studentsTable.Rows[1].Range.ParagraphFormat.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphCenter;
                int i = 1;
                foreach (var currentrep in workers)
                {
                    cellRange = studentsTable.Cell(i + 1, 1).Range;
                    cellRange.Text = currentrep.id_worker.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 2).Range;
                    cellRange.Text = currentrep.name_worker.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 3).Range;
                    cellRange.Text = currentrep.surname_worker.ToString();
                    cellRange.ParagraphFormat.Alignment =
                     Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 4).Range;
                    cellRange.Text = currentrep.patronymic.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 5).Range;
                    cellRange.Text = currentrep.age.ToString();
                    cellRange = studentsTable.Cell(i + 1, 6).Range;
                    cellRange.Text = currentrep.family_status.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 7).Range;
                    cellRange.Text = currentrep.gender.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 8).Range;
                    cellRange.Text = currentrep.id_post.ToString();
                    cellRange.ParagraphFormat.Alignment =
                     Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 9).Range;
                    cellRange.Text = currentrep.id_history.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 10).Range;
                    cellRange.Text = currentrep.id_category.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    i++;
                }
                Word.Paragraph countStudentsParagraph = document.Paragraphs.Add();
                Word.Range countStudentsRange =
                countStudentsParagraph.Range;
                countStudentsRange.Text = $"Количество работников -{workers.Count()}";
                countStudentsRange.Font.Color = Word.WdColor.wdColorDarkRed;
                countStudentsRange.InsertParagraphAfter();
                document.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);

                app.Visible = true;
                document.SaveAs2(@"C:\Users\Администратор\Desktop\a.docx");
                document.SaveAs2(@"C:\Users\Администратор\Desktop\a.pdf",Word.WdExportFormat.wdExportFormatPDF);   
            }
        }

        private void W_upd_button_Click(object sender, RoutedEventArgs e)
        {
            Model1 m = new Model1();
            var query =
            from Worker in m.Workers
            select new { Worker.id_worker, Worker.name_worker, Worker.surname_worker, Worker.patronymic, Worker.age, Worker.family_status, Worker.gender, Worker.id_post, Worker.id_history, Worker.id_category };

            WorkersTable.ItemsSource = query.ToList();
        }

        private void C_upd_but_Click(object sender, RoutedEventArgs e)
        {
            Model1 m = new Model1();
            var query =
              from Category in m.Category
              select new { Category.id_category, Category.category1, Category.id_post, Category.factor };
            CaregoryTable.ItemsSource = query.ToList();

        }
    }
}
