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

namespace CarDealerShow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InventoryCars service = new InventoryCars();
        public MainWindow()
        {
            InitializeComponent();
            
           

            listCar.ItemsSource = service.GetCars();

            
        }

        private void listCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cars cars = (Cars) ((ListBox)e.Source).SelectedItem;
            Txt_registerN.Text = cars.RegistrationNumber;
            Txt_make.Text = cars.Make;
            Txt_model.Text = cars.Model;
            Txt_year.Text = Convert.ToString(cars.Year);
            Txt_price.Text = Convert.ToString(cars.Price);
            imageCar.Source = new BitmapImage(new Uri($"/images/{cars.ImagePath}", UriKind.Relative));
        }   
        
    }
}
