using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace PhoneCompare.Controllers
{
    public class PhonesController : Controller
    {
        private readonly IPhoneRepository phonesRepository;

        public PhonesController(IPhoneRepository phonesRepository)
        {
            this.phonesRepository = phonesRepository;
        }

        public ActionResult ComparePhones()
        {
            var phones = phonesRepository.GetAllPhones();
            return View(phones);
        }

        public ActionResult GetPhoneDetails(int id)
        {
            var phone = phonesRepository.GetPhoneById(id);
            return PartialView("_PhoneDetails", phone);
        }
    }
}