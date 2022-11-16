using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesGunBesOdev.Abstract;

namespace BesGunBesOdev.Concrete
{
    public class CustomerManager : ICrudService
    {

        ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add(Entity entity)
        {
            if (_customerCheckService.CheckIfRealPerson(entity))
            {
                Console.WriteLine(entity.Name + " adlı oyun eklendi");
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi degil");
            }
        }

        public void Delete(Entity entity)
        {
            Console.WriteLine(entity.Name+" kullanıcı adlı üye silindi");
        }

        public void Update(Entity entity)
        {
            Console.WriteLine(entity.Name + " kullanıcı adlı üye bilgileri güncellendi");
        }
    }
}
