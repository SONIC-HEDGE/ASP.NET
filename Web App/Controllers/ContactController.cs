using Microsoft.AspNetCore.Mvc;
using Web_App.Models;

namespace Web_App.Controllers
{
    public class ContactController : Controller
    {
        //temporary
        static private Dictionary<int, ContactModel> _contacts = new Dictionary<int, ContactModel>()
        {
            {1, new(){Id = 1, Email = "wsei@gmail.com", FirstName = "Adam", LastName = "Brzeziak", BirthDate = new DateOnly(1950, 10, 10), PhoneNumber = "666 666 666"}},
            {2, new(){Id = 2, Email = "dgshgds@gmail.com", FirstName = "Marcin", LastName = "Pypec", BirthDate = new DateOnly(1930, 10, 10), PhoneNumber = "444 222 666"}}, 
            {3, new(){Id = 3, Email = "dsdsds@gmail.com", FirstName = "Dupa", LastName = "Debil", BirthDate = new DateOnly(1920, 10, 10), PhoneNumber = "777 111 666"}}
        };

        private static int currentId = 0;
        // Lista kontaktów 
        public ActionResult Index()
        {
            return View(_contacts);
        }
        
        //Dodanie kontaktu formularz 
        public ActionResult Add()
        {
            return View();
        }

        //Odebranie danych z formularza i zapisanie w kontaktach
        [HttpPost]
        public ActionResult Add(ContactModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);   
            }

            model.Id = ++currentId;
            _contacts.Add(model.Id, model);

            return View("Index", _contacts);
        }

        public ActionResult Delete(int id)
        {
            _contacts.Remove(id);
            return View("Index", _contacts);
        }

        public ActionResult Details(int id)
        {
            return View(_contacts[id]);
        }
    }
}
