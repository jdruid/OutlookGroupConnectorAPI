using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

using startupconnector.DAL;
using startupconnector.Models;
using Office365ConnectorSDK;
using System.Web;
using System.Threading.Tasks;

namespace startupconnector.Controllers
{
    public class CardsController : ApiController
    {
        private StartupConnectorDB db = new StartupConnectorDB();

        // POST api/<controller>
        [SwaggerOperation("CreateCard")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public async Task Post([FromBody]StartupCard startupCard)
        {
            // Card object being passed in to the API endpoint
            // TODO: Validation against data..Possible enum for category

            db.StartupCards.Add(new Models.StartupCard
            {
                ID = Guid.NewGuid(),
                Category = startupCard.Category,
                Name = startupCard.Name,
                ContactEmail = startupCard.ContactEmail,
                ContactName = startupCard.ContactName,
                RequestDate = DateTime.Now,
                Inquiry = startupCard.Inquiry,
                Location = startupCard.Location
            });
            db.SaveChanges();

            // Hard coding webHookURL for now.
            // Need to create a Keys.cs file along with a static property.
            string webhookUrl = HttpUtility.UrlDecode(Keys.OutlookWebHookURL);
            
            if (!string.IsNullOrEmpty(webhookUrl))
            {
                Message message = new Message()
                {
                    summary = String.Format("Startup Bot: {0} Request", startupCard.Category),
                    title = String.Format("Startup Name: {0} ({1})", startupCard.Name, startupCard.Location),
                    sections = new List<Section>() {
                        new Section() {
                            activityTitle = String.Format("Contact Name: {0}\n Email: {1}", startupCard.ContactName, startupCard.ContactEmail),
                            activitySubtitle = String.Format("Request: {0}", startupCard.Category),
                            activityText = startupCard.Inquiry,
                            activityImage = "http://startupconnector.azurewebsites.net/img/bot.jpg"
                        }
                    }

                    // Commenting out this portion for now
                    // - Thought was to have actions to "claim" inquiry or to respond directly to inquiry
                    //},
                    //potentialAction = new List<PotentialAction>() {
                    //    new PotentialAction() {
                    //        name = String.Format("Respond to {0}", startupCard.ContactName),
                    //        target = new List<string> { String.Format("http://startupconnector.azurewebsites.net") }
                    //    }
                    //}

                };
                
                await message.Send(webhookUrl);
            }
            
        }
        
    }
}