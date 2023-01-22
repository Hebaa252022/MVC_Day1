using System.Numerics;

namespace MVC_Day1.Models
{
    public static class SampleData
    {
        private static List<People> peoples = new List<People>()
        {
            new People()
            {
            Name= "Heba",
            Email= "Heba@gmai.com",
            Phone="0123476891",
            WillAttend=true
            },
            new People()
            {
            Name= "Nora",
            Email= "Nora@gmai.com",
            Phone="0123476551",
            WillAttend=true

            },
            new People()
            {
            Name= "Shrouk",
            Email= "Shrouk@gmai.com",
            Phone="0129976551",
            WillAttend=true },
            new People()
            {
            Name= "Ahmed",
            Email= "Ahmed@gmail.com",
            Phone="01159874632",
            WillAttend=true
            }
        };
        public static List<People> Peoples { get => peoples; }
        public static void AddPeople(People people)
        {
            peoples.Add(people);
        }
    }
}

