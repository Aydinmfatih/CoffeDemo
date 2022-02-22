using System;
using CoffeDemo.Abstract;
using CoffeDemo.Entities;
using CoffeDemo.Concrete;
namespace CoffeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           BaseCustomerManager customerManager = new NeroCustomerManager();
           customerManager.Save(new Customer{DateOfBirth= new DateTime(1985,1,6),FirstName="engin",LastName="Demiroğ",NationlalityId="35873180016"});
        }
    }
}
