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

namespace igra_fotochki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Image img;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Label_Drop(object sender, DragEventArgs e)
        {
            ((Image)sender).Source = img.Source;
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image label = sender as Image;
            img = label;

            DragDrop.DoDragDrop(label, label.Source, DragDropEffects.Copy);
        }
    }
}
