using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    class Person
    {
        public string Name { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public int Age { get; set; }
        public string BirthDay { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public int CustomerNumber { get; set; }
        public Car Car;
        public bool DriversLicense { get; set; }
        public string BankAccountNumber { get; set; }
        public int MoneyOwed { get; set; }
        public Person()
        {
            DriversLicense = true;
        }
        public Person(string name, string homeAddress, string workAddress, int age,string birthDay,string gender, int phoneNumber,int customerNumber,Car car)
        {
            Name = name;
            HomeAddress = homeAddress;
            WorkAddress = workAddress;
            Age = age;
            BirthDay = birthDay;
            Gender = gender;
            PhoneNumber = phoneNumber;
            CustomerNumber = customerNumber;
            Car = car;
            DriversLicense = true;
        }
        public void HireCar(Car car,int carCost)
        {
            Car = car;
            MoneyOwed += carCost;
        }
        public void ReturnCar(Car car,int payment)
        {
            if (car.Model ==Car.Model && car.Brand == Car.Brand)
            {
                Car = null;
                MoneyOwed -= payment;
            }
        }
    }
}
