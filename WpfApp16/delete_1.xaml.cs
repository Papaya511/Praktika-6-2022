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
    /// Логика взаимодействия для delete_1.xaml
    /// </summary>
    public partial class delete_1 : Window
    {
        public delete_1()
        {
            InitializeComponent();
        }

        private void W_del_button_Click(object sender, RoutedEventArgs e)
        {
            int b;
            Model1 m = new Model1();
            Workers w = new Workers();
            bool isnum1 = Int32.TryParse(Tb1.Text, out b);
            if (isnum1)
            {
                w = m.Workers.Find(int.Parse(Tb1.Text));
                if (w != null)
                {
                    m.Workers.Remove(w);

                  m.SaveChanges();
                }
                else { MessageBox.Show("Несуществующий работник"); }
            }
            else { MessageBox.Show("Ошибка ввода"); }
            this.Close();
        }
        }
    }

