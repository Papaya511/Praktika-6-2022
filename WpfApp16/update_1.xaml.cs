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
    /// Логика взаимодействия для update_1.xaml
    /// </summary>
    public partial class update_1 : Window
    {
        public update_1()
        {
            InitializeComponent();
        }

    

        private void W_upd_b_Click(object sender, RoutedEventArgs e)
        {
            int b;
            bool isnum1 = Int32.TryParse(Tb1.Text, out b);
            bool isnum2 = Int32.TryParse(Tb5.Text, out b);
            bool isnum3 = Int32.TryParse(Tb6.Text, out b);
            bool isnum4 = Int32.TryParse(Tb7.Text, out b);
           
            bool isnum6 = Int32.TryParse(Tb9.Text, out b);
            
            if (isnum1 && isnum2 && isnum3 && isnum4  && isnum6)
            {
                using (Model1 db = new Model1())
            {
                Workers w = new Workers();
                w = db.Workers.Find(int.Parse(Tb1.Text));
                if (w != null)
                {
                    w.name_worker = Tb2.Text;
                    w.surname_worker = Tb3.Text;
                    w.patronymic = Tb4.Text;
                        w.id_history = int.Parse(Tb5.Text);
                        w.id_category = int.Parse(Tb6.Text);
                        w.age = int.Parse(Tb7.Text);
                    w.family_status = Tb8.Text;
                    
                    w.id_post = int.Parse(Tb9.Text);
                    w.id_history = int.Parse(Tb5.Text);
                        w.gender = Tb10.Text;
                        
                    db.SaveChanges();

                }
            }
            }
            else { MessageBox.Show("Ошибка ввода"); }
            this.Close();
        }
    }
}
