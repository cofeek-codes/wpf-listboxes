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
using System.IO;

namespace kelt_horoscope
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dictionary<int, string> dates = new Dictionary<int, string>();

            Dictionary<string, string> descripts = new Dictionary<string, string>();

            


            //data in files


            foreach (string file in Directory.EnumerateFiles("data", "*.txt"))
            {
                descripts.Add(File.ReadLines(file).ToList()[0], File.ReadAllText(file));

            }



            //data in files








            foreach (TextBlock item in dateList.Items)
            {
                item.AddHandler(UIElement.MouseDownEvent,
   new MouseButtonEventHandler(ListItem_MouseClick), true);

                dates.Add(dateList.Items.IndexOf(item), item.Text);

            }

            void ListItem_MouseClick(object sender, MouseEventArgs e)
            {
                TextBlock itemTextBlock = (TextBlock)sender;
            
                int pos = dateList.Items.IndexOf(itemTextBlock);
                
                type_tbl.Text = descripts.Keys.ToArray()[pos].ToString();
                desc_tbl.Text = descripts.Values.ToArray()[pos].ToString();
                  


            }


        }

      
    }
}
