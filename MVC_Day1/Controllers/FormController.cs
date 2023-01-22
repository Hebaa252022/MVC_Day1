using Microsoft.AspNetCore.Mvc;
using MVC_Day1.Models;

namespace MVC_Day1.Controllers.Form
{
    public class FormController : Controller
    {

        public ViewResult FormDetails()
        {
            return View("AddPeople");
        }
        public IActionResult GetAllPeoples(People people)
        {
            SampleData.AddPeople(people);


            List<People> peoples = SampleData.Peoples.Where(p => p.WillAttend == true).ToList();
            if (peoples.Count > 0)
            {
                return View("PeopleDetails", peoples);
            }
            else
            {
                return View("seeyou", peoples);
            }
        }
        public IActionResult AddPeople()
        {          
                return View("thankyou");          
        }
    }
}
