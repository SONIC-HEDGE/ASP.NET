using Microsoft.AspNetCore.Mvc;
using Web_App.Models;
using Web_App.Models.Services;

namespace Web_App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // Lista kontaktów 
        public ActionResult Index()
        {
            return View(_contactService.GetAll());
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

            _contactService.Add(model);
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            _contactService.Delete(id);
            return View("Index");
        }

        public ActionResult Details(int id)
        {
            return View(_contactService.GetById(id));
        }
        
        public ActionResult Edit(int id)
        {
            return View(_contactService.GetById(id));
        }
        [HttpPost]
        public ActionResult Edit(ContactModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _contactService.Update(model);
            return View("Index");
        }
    }
}