﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IAplicantService
    {
        public void ApplyForMask(Person person)
        {
            
        }

        public bool CheckPerson(Person person)
        {
            return true;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
