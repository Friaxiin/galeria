using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace galeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Image> images = new List<Image>();
        public MainWindow()
        {
            InitializeComponent();

        }
        public void GetImages()
        {
            string[] txt = File.ReadAllLines("data.txt");

            foreach (string s in txt)
            {
                Images img = new Images();
                
                string[] image = s.Split(",");

                img.src = image[0];
                img.name = image[1];
                img.author = image[2];
                img.date = DateTime.Parse(image[3]);

                StackPanel stackPanel = new StackPanel();
                Image imgLbl = new Image();
                imgLbl.Source = new BitmapImage(new Uri("", UriKind.Relative)); ;
                //panel.Children.Add();
            }
            
        }
    }
}