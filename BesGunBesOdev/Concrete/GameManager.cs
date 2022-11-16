using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesGunBesOdev.Abstract;

namespace BesGunBesOdev.Concrete
{
    public class GameManager : ICrudService
    {
        public void Add(Entity entity)
        {
            Console.WriteLine(entity.Name+" adlı oyun eklendi");
        }

        public void Delete(Entity entity)
        {
            Console.WriteLine(entity.Name + " adlı oyun satışdan kaldırıldı");
        }

        public void Update(Entity entity)
        {
            Console.WriteLine(entity.Name + " adlı oyun satış şartları güncellendi");
        }
    }
}
