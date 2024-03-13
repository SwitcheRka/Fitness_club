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

namespace lll
{
    /// <summary>
    /// Логика взаимодействия для first.xaml
    /// </summary>
    public partial class first : Window
    {
        public first()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentList = db.product.ToList();
                LView.ItemsSource = currentList;
            }
        }

        private void TBox_Search(object sender, TextChangedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentMovies = db.product.ToList();
                LView.ItemsSource = currentMovies.OrderBy(p => p.id).ToList();

            }
        }

        private void BtnReservation_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
