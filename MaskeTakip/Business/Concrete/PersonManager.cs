﻿using Business.Abstract;
using Entities.Concrete;
using Mernis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IAplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
            //return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
