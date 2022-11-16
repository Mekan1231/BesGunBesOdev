using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BesGunBesOdev.Entities;

namespace BesGunBesOdev.Concrete
{
    public class SalesManager
    {
        public void Sale(Campaign campaign, Customer customer, Game game)
        {
            Console.WriteLine(game.Name+" adlı oyun "+customer.Name+" adlı kişiye "+campaign.Name+
                " adlı kampanya uygylanarak satıldı");
        }
    }
}
