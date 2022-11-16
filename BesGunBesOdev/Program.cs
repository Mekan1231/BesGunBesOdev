using System;
using BesGunBesOdev.Abstract;
using BesGunBesOdev.Concrete;
using BesGunBesOdev.Entities;

namespace BesGunBesOdev
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer
            {
                Name = "Mekancik",
                Id = 1,
                FirstName = "Mekan",
                LastName = "Annamyradov",
                NationalityId = 99620818980,
                DateOfBirth = new DateTime(1996, 12, 31)
            };

            Campaign campaign = new Campaign
            {
                Name = "Yaz kamoanyası",
                Id = 1,
                Explanation = "Kırmızı etiketli ürünlerde 50% varan indrim"
            };

            Game game = new Game
            {
                Id = 1,
                Name = "Pubg Mobile",
                Price = 100
            };

            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(customer);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            

        }
    }
}
