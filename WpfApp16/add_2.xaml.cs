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
    /// Логика взаимодействия для add_2.xaml
    /// </summary>
    public partial class add_2 : Window
    {
        public add_2()
        {
            InitializeComponent();
        }

        private void C_add_button_Click(object sender, RoutedEventArgs e)
        {
            int b;
            bool isnum2 = Int32.TryParse(Tb2.Text, out b);
            bool isnum3 = Int32.TryParse(Tb3.Text, out b);
            bool isnum4 = Int32.TryParse(Tb4.Text, out b);
            if (isnum2 && isnum3 && isnum4)
            {
                using (Model1 db = new Model1())
                {
                        Category w = new Category();
                        w.id_category = int.Parse(Tb2.Text);
                        w.id_post = int.Parse(Tb3.Text);
                        w.factor = int.Parse(Tb4.Text);
                        db.Category.Add(w);
                        db.SaveChanges();
                    
                }
            }
            else { MessageBox.Show("Ошибка ввода"); }
            this.Close();
        }
    }
}
