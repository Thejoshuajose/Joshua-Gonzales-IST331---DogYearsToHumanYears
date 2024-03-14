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

namespace Joshua_Gonzales___IST331___DogYearsToHumanYears
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            btnCalculate.IsEnabled = false;

        }

        private void txtCurrentDate_Initialized(object sender, EventArgs e)
        {
            txtCurrentDate.Text = DateTime.Now.ToString();

        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            AlwaysRunning();
            if (dogbdayvalid == true)
            {
                dogHumanYears = ((DateTime.Today - dogBirthday).Days)/365;
                txtDogYears.Text = dogHumanYears.ToString();
            }
        }

        private void calDogBirthday_GotFocus(object sender, RoutedEventArgs e)
        {
            AlwaysRunning();
        }

        private void calDogBirthday_LostFocus(object sender, RoutedEventArgs e)
        {
            AlwaysRunning();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            
            AlwaysRunning();
        }

        private void calDogBirthday_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {

            AlwaysRunning();

        }

        private void calDogBirthday_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            AlwaysRunning();

        }
        private void AlwaysRunning()
        {
            txtCurrentDate.Text = DateTime.Now.ToString();


        }

        private void BirthdayValidator()
        {
            if ((calDogBirthday.SelectedDate >= DateTime.Now) && calDogBirthday.IsLoaded)
            {
                MessageBox.Show("Dog's Date of birth cannot be in the future. Please select a different date.");
                calDogBirthday.SelectedDate = DateTime.Now.Date;
                btnCalculate.IsEnabled = false;
            }
            else
            {
                dogBirthday = calDogBirthday.SelectedDate.Value;
                dogbdayvalid = true;
                btnCalculate.IsEnabled = true;
            }
        }

        private void calDogBirthday_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            BirthdayValidator();

        }
    }



}