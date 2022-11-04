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
using System.Windows.Shapes;

namespace WpfApp16
{
    /// <summary>
    /// Логика взаимодействия для add_1.xaml
    /// </summary>
    public partial class add_1 : Window
    {
        public add_1()
        {
            InitializeComponent();
        }

        private void W_add_button_Click(object sender, RoutedEventArgs e)
        {
            int b;
            bool isnum1 = Int32.TryParse(Tb5.Text, out b);
            bool isnum2 = Int32.TryParse(Tb4.Text, out b);
            bool isnum3 = Int32.TryParse(Tb8.Text, out b);
            bool isnum4 = Int32.TryParse(Tb6.Text, out b);
            
            if (isnum1 && isnum2 && isnum3 && isnum4)
            {
                using (Model1 db = new Model1())
                {
                    Workers w = new Workers();
                    w.name_worker = Tb1.Text;
                    w.surname_worker = Tb2.Text;
                    w.patronymic = Tb3.Text;
                    w.id_history = int.Parse(Tb4.Text);
                    w.id_category = int.Parse(Tb5.Text);
                    w.age = int.Parse(Tb6.Text);
                    w.family_status = Tb7.Text;
                    w.id_post = int.Parse(Tb8.Text);
                    w.gender = Tb9.Text;
                    db.Workers.Add(w);
                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Ошибка ввода"); }
            this.Close();
        }
    }
}
