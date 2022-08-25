using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        //public string SomeText { get; set; } = "Salam WPF";

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string name=null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


  



        private string someText;
        public string SomeText
        {
            get { return someText; }
            set { someText = value; OnPropertyChanged(); }
        }



        public Car MyCar { get; set; }



        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;// IT IS IMPORTANT
            SomeText = "Salam WPF";
            MyCar = new Car
            {
                Model = "Granturismo",
                Vendor = "Maserati",
                Year = 2020
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var linear = new LinearGradientBrush();
            linear.GradientStops.Add(new GradientStop
            {
                Color = Colors.Black,
                Offset = 0,
            });
            linear.GradientStops.Add(new GradientStop
            {
                Color = Colors.Red,
                Offset = 1,
            });
            this.Resources["PrimaryColor"] = linear;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SomeText = "Clicked";
        }
    }
}
