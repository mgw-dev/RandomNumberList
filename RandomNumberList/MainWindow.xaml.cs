using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using static RandomNumberList.RandomNumberListGenerator;

namespace RandomNumberList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Start { get; set; } = 1;
        public int End { get; set; } = 10000;

        public ObservableCollection<int> Numbers { get; } = new ObservableCollection<int>();
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            GetNumbers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetNumbers();
        }

        private void GetNumbers()
        {
            this.Cursor = Cursors.Wait;
            Numbers.Clear();
            GetRandomList(Start, End).ForEach(x => Numbers.Add(x));
            this.Cursor = Cursors.Arrow;
        }
    }
}
