using Microsoft.AspNetCore.Mvc;
using QueryString.Models;
using System;

namespace QueryString.Controllers
{
    public class HomeController : Controller
    {
        // https://localhost:7264?name=Greed&age=30
        public string Index(string name = "Undefined", int age = 0)
        {
            return $"Name: {name}, Age: {age}";
        }

        // https://localhost:7264/home/person?name=Greed&age=30
        public string Person(Person person)
        {
            return $"Name: {person.Name}, Age: {person.Age}";
        }

        // https://localhost:7264/home/array?people=Greed&people=Marcus&people=Henry
        // https://localhost:7264/home/array?[0]=Greed&[1]=Marcus&[2]=Henry
        public string Array(string[] people)
        {
            string result = string.Empty;

            foreach (var item in people)
                result += $"{item}; ";

            return result;
        }

        // https://localhost:7264/home/arraypersons?people[0].name=Greed&people[0].age=30&people[1].name=Marcus&people[1].age=45&people[2].name=Henry&people[2].age=23
        // https://localhost:7264/home/arraypersons?[0].name=Greed&[0].age=30&[1].name=Marcus&[1].age=45&[2].name=Henry&[2].age=23
        public string ArrayPersons(Person[] people)
        {
            string result = string.Empty;

            foreach (var person in people)
                result += $"Name: {person.Name}; Age: {person.Age}\n";

            return result;
        }

        // https://localhost:7264/home/dictionary?people[Greed]=30&people[Marcus]=40&&people[Henry]=23
        public string Dictionary(Dictionary<string, int> people)
        {
            string result = string.Empty;

            foreach (var person in people)
            {
                result += $"Name: {person.Key}, Age: {person.Value}\n";
            }

            return result;
        }
    }
}
