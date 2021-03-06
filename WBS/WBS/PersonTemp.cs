﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    public partial class Person
    {

        public Car Car;
        
        /////////////////////

        public Person(string name, string homeAddress, string workAddress, int age, DateTime birthDay, string gender, int phoneNumber, int customerNumber, string bankaccountNumber)
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

        public void HireCar(int carID, int carCost)
        {
            Car car = Program.db.Cars.Find(carID);
            car.Owner = id;
            Program.db.SaveChanges();
            MoneyOwed += carCost;
        }
        public void ReturnCar(int carID, int payment)
        {
            Car car = Program.db.Cars.Find(carID);
            car.Owner = null;
            Program.db.SaveChanges();
            MoneyOwed -= payment;

        }
    }
}
