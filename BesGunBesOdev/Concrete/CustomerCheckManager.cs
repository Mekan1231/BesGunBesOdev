using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesGunBesOdev.Abstract;
using BesGunBesOdev.Entities;

namespace BesGunBesOdev.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Entity customer)
        {
            return false;
        }
    }
}
