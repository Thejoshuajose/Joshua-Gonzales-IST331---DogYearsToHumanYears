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
        Dog dog = new Dog();
        DateTime todaysDate = DateTime.Now.Date;


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
            BirthdayValidator();
            for (int i=0;i<2; i++)
                if (dog.getDogBdayValid() == true)
                {
                dog.setDogAgeInDogYears(dog.DogYearCalculation(dog.getDogHumanAge(), dog.getDogWeight()));
                txtDogYears.Text = (dog.getDogAgeinDogYears().ToString()+" years " + dog.getDogMonthAge() + " months");
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
            
            //AlwaysRunning();
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
                DateTime dogBirthday = calDogBirthday.SelectedDate ?? DateTime.MinValue;
                dog.setDogBirthday(dogBirthday);
                TimeSpan t1 = DateTime.Today - dogBirthday;
                float dogmonthcalcvar = (float)(t1.TotalDays / 30.4166667);
                
                double years = (dogmonthcalcvar / 12);
                int dogHumanAge = (int)years ;
                dog.setDogMonthAge(dog.DogMonthCalculation( (float) ((dogmonthcalcvar/12)-Math.Floor(dogmonthcalcvar / 12))));
                dog.setDogHumanAge(dogHumanAge);
                

                dog.setDogBdayValid(true);
                btnCalculate.IsEnabled = true;
            }
        }

        private void calDogBirthday_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            BirthdayValidator();
            
            
        }

        private void txtDogWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDogWeight.Text != "0" && txtDogWeight.Text != "")
            {
                dog.setDogWeight(int.Parse(txtDogWeight.Text));
            }
        }

        private void txtDogWeight_GotFocus(object sender, RoutedEventArgs e)
        {
             if(txtDogWeight.Text == "0")
             {
                txtDogWeight.Clear();
             }

        }

        private void txtDogWeight_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtDogWeight.Text == "")
            {
                txtDogWeight.Text = "0";
            }
            else
            {
                dog.setDogWeight(int.Parse(txtDogWeight.Text));
            }

        }
    }



}