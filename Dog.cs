using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joshua_Gonzales___IST331___DogYearsToHumanYears
{
    class Dog
    {
        bool dogbdayvalid;
         int dogHumanYears; 
         DateTime dogBirthday;
        int dogAge;

        public Dog(int dogsHumanYears,int age, bool isorisnot, DateTime dogsBirthday) 
        {
            this.dogbdayvalid = isorisnot;
            this.dogHumanYears = dogsHumanYears;
            this.dogAge = age;
            this.dogBirthday = dogsBirthday;

        }

        public Dog(int dogsHumanYears, int age, DateTime dogsBirthday)
        {
            this.dogbdayvalid = false;
            this.dogHumanYears = dogsHumanYears;
            this.dogAge = age;
            this.dogBirthday = dogsBirthday;

        }

        public Dog(int dogsHumanYears,DateTime dogsBirthday)
        {
            this.dogAge = 0;
            this.dogHumanYears = dogsHumanYears;
            this.dogBirthday = dogsBirthday;
            this.dogbdayvalid = false;
        }

        public Dog(DateTime dogsBirthday)
        {
            this.dogAge = 0;
            this.dogHumanYears = 0;
            this.dogBirthday = dogsBirthday;
            this.dogbdayvalid = false;
        }
        public Dog()
        {
            this.dogAge = 0;
            this.dogHumanYears = 0;
            this.dogBirthday = DateTime.Today;
            this.dogbdayvalid = false;
        }

        public void setDogAge(int age) 
        {
            this.dogAge = age; 
        }

        public void setDogBdayValid(bool isornot)
        {
            this.dogbdayvalid = isornot;
        }
        public void setDogHumanYears(int dogsHumanYears)
        {
            this.dogHumanYears = dogsHumanYears;
        }
        public void setDogBirthday(DateTime dogsBirthday)
        {
            this.dogBirthday = dogsBirthday;
        }

        public static getDogAge()
        {
            return 
        }
    }
}
