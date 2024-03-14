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

        public Dog() 
        {

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

        public  getDogAge()
        {
            return 
        }
    }
}
