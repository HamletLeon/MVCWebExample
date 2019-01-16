using MVCWebTest.Models;
using MVCWebTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebTest.Controllers
{
    public class ContactsController : Controller
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public ContactsController()
        {
            Contacts.AddRange(new List<Contact>()
            {
                new Contact { Id = 1, FirstName = "Test 1", LastName = "Hey", Email = "Test1@email.com" },
                new Contact { Id = 2, FirstName = "Test 2", LastName = "Hey", Email = "Test2@email.com" },
                new Contact { Id = 3, FirstName = "Test 3", LastName = "Hey", Email = "Test3@email.com" },
                new Contact { Id = 4, FirstName = "Test 4", LastName = "Hey", Email = "Test4@email.com" },
                new Contact { Id = 5, FirstName = "Test 5", LastName = "Hey", Email = "Test5@email.com" }
            });
        }
        // GET: Contacts
        public ActionResult Index()
        {
            return View(Contacts);
        }

        public ActionResult Edit(int id)
        {
            var contact = Contacts.Where(c => c.Id == id).FirstOrDefault();
            if (contact == null) return RedirectToAction("Index");

            var categories = new List<Category>()
            {
                new Category { Id = 1, Description = "Cat 1" },
                new Category { Id = 2, Description = "Cat 2" },
                new Category { Id = 3, Description = "Cat 3" },
                new Category { Id = 4, Description = "Cat 4" },
                new Category { Id = 5, Description = "Cat 5" }
            };

            var model = new ContactEditViewModel
            {
                Contact = contact,
                Categories = categories.Select(c => new CheckBoxListItem
                { Id = c.Id, Display = c.Description }).ToList(),
                PhoneNumbers = contact.PhoneNumbers ?? new List<PhoneNumber>() { new PhoneNumber() }
            };

            return View(model);
        }

        [HttpPost]
        public PartialViewResult AddPhoneNumber()
        {
            return PartialView("PhoneNumberLine");
        }

        [HttpPost]
        public ActionResult Edit(ContactEditViewModel model)
        {
            // Update contact from database
            if (ModelState.IsValid)
                return RedirectToAction("Index");

            ModelState.AddModelError("Error", "Server side error occurred");
            return View(model);
        }
    }
}