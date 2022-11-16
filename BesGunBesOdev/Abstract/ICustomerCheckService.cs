using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesGunBesOdev.Entities;

namespace BesGunBesOdev.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Entity customer);
    }
}
