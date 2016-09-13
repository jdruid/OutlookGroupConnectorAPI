using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using startupconnector.Models;

namespace startupconnector.DAL
{
    public class StartupCardInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StartupConnectorDB>
    {
        protected override void Seed(StartupConnectorDB db)
        {
            // Seeding DB 

            var cards = new List<StartupCard>
            {
                new StartupCard {ID = Guid.NewGuid(), Name="optimusprime", ContactEmail="test@test.com", ContactName="Test", Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now },
                new StartupCard {ID = Guid.NewGuid(), Name="bumblebee",ContactEmail="test@test.com", ContactName="Test", Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now  },
                new StartupCard {ID = Guid.NewGuid(), Name="jazz",ContactEmail="test@test.com", ContactName="Test", Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now  },
                new StartupCard {ID = Guid.NewGuid(), Name="sideswipe",ContactEmail="test@test.com", ContactName="Test", Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now  },
                new StartupCard {ID = Guid.NewGuid(), Name="jetfire", ContactEmail="test@test.com", ContactName="Test",Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now  },
            };

            cards.ForEach(s => db.StartupCards.Add(s));
            db.SaveChanges();

        }
    }
}








