using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        //Sonarqube
        public void ApplyForMask(Person person)
        {
            
        }

        public bool CheckPerson(Person person)
        {
            return person.NationalIdentity == 0;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
