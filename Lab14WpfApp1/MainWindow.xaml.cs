using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab14WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Family> families;
        public MainWindow()
        {
            
            InitializeComponent();
            families = new ObservableCollection<Family>();
            families.Add(new Family()
            {
                Name = "НСЖ_24.30.10",
                Description = "Панель стеновая наружная сплошная",
                AmountOfSamples = 5,
                FamilyType = FamilyTypes.WallPanel
            });
            families.Add(new Family()
            {
                Name = "ПП_40.4",
                Description = "Плита перекрытия",
                AmountOfSamples = 5,
                FamilyType = FamilyTypes.FloorPanel
            });
            families.Add(new Family()
            {
                Name = "ПП_60.4-1",
                Description = "Плита перекрытия",
                AmountOfSamples = 25,
                FamilyType = FamilyTypes.FloorPanel
            });
            families.Add(new Family()
            {
                Name = "ПП_60.4-2",
                Description = "Плита перекрытия",
                AmountOfSamples = 2,
                FamilyType = FamilyTypes.FloorPanel
            });
            families.Add(new Family()
            {
                Name = "Бм_24.20",
                Description = "Балка монолитная",
                AmountOfSamples = 1,
                FamilyType = FamilyTypes.Beam
            });
            listBox.ItemsSource = families;
        }
    }

}
