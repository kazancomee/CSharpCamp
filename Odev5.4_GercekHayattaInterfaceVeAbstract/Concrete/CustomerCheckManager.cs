﻿using Odev5._4_GercekHayattaInterfaceVeAbstract.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._4_GercekHayattaInterfaceVeAbstract.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
