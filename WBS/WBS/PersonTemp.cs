using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    public partial class Person
    {
        //public string Name { get; set; }
        //public string HomeAddress { get; set; }
        //public string WorkAddress { get; set; }
        //public int Age { get; set; }
        //public string BirthDay { get; set; }
        //public string Gender { get; set; }
        //public int PhoneNumber { get; set; }
        //public int CustomerNumber { get; set; }
        public Car Car;
        //public bool DriversLicense { get; set; }
        //public string BankAccountNumber { get; set; }
        //public int MoneyOwed { get; set; }
      
        /////////////////////
      
        public Person(string name, string homeAddress, string workAddress, int age, DateTime birthDay, string gender, int phoneNumber, int customerNumber,string bankaccountNumber)
        {
            Name = name;
            HomeAddress = homeAddress;
            WorkAddress = workAddress;
            Age = age;
            Birthday = birthDay;
            Gender = gender;
            PhoneNumber = phoneNumber;
            CustomerNumber = customerNumber;
            MoneyOwed = 0;
            BankAccountNumber = bankaccountNumber;
            DriversLicense = 1;
        }
        public void HireCar(Car car, int carCost)
        {
            Car = car;
            MoneyOwed += carCost;
        }
        public void ReturnCar(Car car, int payment)
        {
            if (Car != null)
            {
                if (car.Model == Car.Model && car.Brand == Car.Brand)
                {
                    Car = null;
                    MoneyOwed -= payment;
                }
            }
        }
    }
}
