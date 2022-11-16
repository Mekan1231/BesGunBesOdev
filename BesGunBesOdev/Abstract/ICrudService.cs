using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesGunBesOdev.Abstract
{
    internal interface ICrudService
    {
        void Add(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
    }
}
