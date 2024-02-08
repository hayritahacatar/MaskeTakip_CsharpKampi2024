using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PharmacyManager : ISellerService
    {
        private IApplicantService _applicantService;

        public PharmacyManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;

        }

        public void SellMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske satıldı");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske SATILAMADI");
            }
        }
    }
}
