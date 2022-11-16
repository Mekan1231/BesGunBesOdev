using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesGunBesOdev.Abstract;

namespace BesGunBesOdev.Concrete
{
    public class CampaignManager : ICrudService
    {
        public void Add(Entity entity)
        {
            Console.WriteLine(entity.Name+" adlı yeni bir kampanya eklendi");
        }

        public void Delete(Entity entity)
        {
            Console.WriteLine(entity.Name+" adlı kampanya sistemden silindi");
        }

        public void Update(Entity entity)
        {
            Console.WriteLine(entity.Name+" adlı kamya şartları güncellendi");
        }
    }
}
