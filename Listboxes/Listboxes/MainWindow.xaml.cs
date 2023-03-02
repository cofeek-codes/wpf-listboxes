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

namespace Listboxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

          

            // calculated

            float size_calculated = 0;
            float price_calculated = 0;

            // calculated

            count_btn.Click += Count_btn_Click;

            

        }

        private void Count_btn_Click(object sender, RoutedEventArgs e)
        {
            float width = Convert.ToSingle(width_tbx.Text);
            float height = Convert.ToSingle(height_tbx.Text);

            switch (material_cmb.SelectedIndex)
            {
                // plastic

                case 0:

                    size_tbk.Text = "Size: " + (width * height).ToString();
                    price_tbk.Text = "Price: " + (width * height * 300).ToString();

                    break;
 
                    // aluminum

                case 1:


                    size_tbk.Text = "Size: " + (width * height).ToString();
                    price_tbk.Text = "Price: " + (width * height * 300 * 2).ToString();
                    break;

                default:
                    MessageBox.Show("choose material");
                    break;
            }
        }
    }
}
