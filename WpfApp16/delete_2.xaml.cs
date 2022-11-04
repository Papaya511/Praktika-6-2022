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
    /// Логика взаимодействия для delete_2.xaml
    /// </summary>
    public partial class delete_2 : Window
    {
        public delete_2()
        {
            InitializeComponent();
        }

        private void C_del_button_Click(object sender, RoutedEventArgs e)
        {
            int b;
            Model1 m = new Model1();
            Category w = new Category();
            bool isnum1 = Int32.TryParse(Tb1.Text, out b);
            if (isnum1)
            {
                w = m.Category.Find(int.Parse(Tb1.Text));
                if (w != null)
                {
                    m.Category.Remove(w);

                    m.SaveChanges();
                }
                else { MessageBox.Show("Несуществующая категория"); }
            }
            else { MessageBox.Show("Ошибка ввода"); }
            this.Close();
        }
    }
}
