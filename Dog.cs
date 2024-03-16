using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Joshua_Gonzales___IST331___DogYearsToHumanYears
{
    class Dog
    {
        bool dogbdayvalid;
        static int dogAgeInHumanYears;
        int dogHumanAge;
        int dogAgeinDogYears;
        DateTime dogBirthday;
        int dogAge;
        float dogMonth;
        int dogWeight;
        string dogMonthAge;
        

        List<int> smallDog = [0,15, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76, 80];
        List<int> mediumDog = [0,15, 24, 28, 32, 36, 42, 47, 51, 56, 60, 65, 69, 74, 78, 83, 87];
        List<int> largeDog = [0,15, 24, 28, 32, 36, 45, 50, 55, 61, 66, 72, 77, 82, 88, 93, 99];
        List<int> giantDog = [0,12,22,31,38,45,49,56,64,71,79,86,93,100,107,114,121];


        public Dog(int dogsHumanYears,int age, bool isorisnot, DateTime dogsBirthday, int dogWeight,int dogHumanAge) 
        {
            this.dogbdayvalid = isorisnot;
            this.dogAgeinDogYears = dogsHumanYears;
            this.dogAge = age;
            this.dogBirthday = dogsBirthday;
            this.dogWeight = dogWeight;
            this.dogHumanAge = dogHumanAge;

        }

        public Dog(int dogAgeinDogYears, int age, DateTime dogsBirthday, int dogWeight, int dogHumanAge)
        {
            this.dogbdayvalid = false;
            this.dogAgeinDogYears = dogAgeinDogYears;
            this.dogAge = age;
            this.dogBirthday = dogsBirthday;
            this.dogWeight = dogWeight;
            this.dogHumanAge = dogHumanAge;


        }

        public Dog(int dogAgeinDogYears, DateTime dogsBirthday, int dogWeight, int dogHumanAge)
        {
            this.dogAge = 0;
            this.dogAgeinDogYears = dogAgeinDogYears;
            this.dogBirthday = dogsBirthday;
            this.dogbdayvalid = false;
            this.dogWeight = dogWeight;
            this.dogHumanAge = dogHumanAge;

        }

        public Dog(DateTime dogsBirthday, int dogWeight, int dogHumanAge)
        {
            this.dogAge = 0;
            this.dogAgeinDogYears = 0;
            this.dogBirthday = dogsBirthday;
            this.dogbdayvalid = false;
            this.dogWeight = dogWeight;
            this.dogHumanAge = dogHumanAge;

        }
        public Dog(DateTime dogsBirthday, int dogWeight)
        {
            this.dogAge = 0;
            this.dogAgeinDogYears = 0;
            this.dogBirthday = dogsBirthday;
            this.dogbdayvalid = false;
            this.dogWeight = dogWeight;
            this.dogHumanAge = 0;

        }
        public Dog()
        {
            this.dogAge = 0;
            this.dogAgeinDogYears = 0;
            this.dogBirthday = DateTime.Today;
            this.dogbdayvalid = false;
            this.dogWeight = 0;
            this.dogHumanAge = 0;

        }

        public void setDogAge(int age) 
        {
            this.dogAge = age; 
        }
        public void setDogWeight(int dogWeight)
        {
             this.dogWeight = dogWeight;
        }

        public  void setDogBdayValid(bool isornot)
        {
            this.dogbdayvalid = isornot;
        }
        public  void setDogAgeInDogYears(int dogsHumanYears)
        {
            this.dogAgeinDogYears = dogsHumanYears;
        }
        public  void setDogBirthday(DateTime dogsBirthday)
        {
            this.dogBirthday = dogsBirthday;
        }

        public void setDogHumanAge(int dogHumanAge)
        {
            this.dogHumanAge = dogHumanAge;
        }
        
        public void setDogMonthAge(string dogMonthAge)
        {
            this.dogMonthAge = dogMonthAge;
        }

        public int getDogAge()
        {
            return dogAge;
        }

        public DateTime getDogBirthday()
        {
            return dogBirthday;
        }
        public int getDogAgeinDogYears()
        {
            return dogAgeinDogYears;
        }
        public int getDogHumanAge()
        {
            return dogHumanAge;
        }
        public bool getDogBdayValid()
        {
            return dogbdayvalid;
        }
        public int getDogWeight()
        {
            return dogWeight;
        }

        public string getDogMonthAge()
        {
            return dogMonthAge;
        }

        public int DogYearCalculation(int dogAgeInDogHumanYears, int dogWeight)
        {
            int age = 0;

            if(dogWeight <= 20)
            {
               age = smallDog[dogAgeInDogHumanYears];
            }
            if (dogWeight >= 21 && dogWeight <= 50)
            {
                age = mediumDog[dogAgeInDogHumanYears];
            }
            if (dogWeight >= 51 && dogWeight <= 100)
            {
                age = largeDog[dogAgeInDogHumanYears];
            }
            if (dogWeight > 100)
            {
                age = giantDog[dogAgeInDogHumanYears];
            }

            return age;
            
        }


        public string DogMonthCalculation(float dogMonth)
        {
            double mon = 0;
            mon = (double)(Math.Round(((dogMonth * 12)*1.25),2));

            string months = mon.ToString();

            return months;
        }

        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dog Weight: " + getDogWeight());
            sb.AppendLine("Dog Birthday: " + getDogBirthday());
            sb.AppendLine("Dog's Age in Human Years: " + getDogHumanAge());
            sb.AppendLine("Dog's Age in Dog Years: " + getDogAgeinDogYears());
            return sb.ToString();
        }
    }
}
