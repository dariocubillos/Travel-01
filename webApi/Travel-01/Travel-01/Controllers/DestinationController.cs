using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Travel_01.models;

namespace Travel_01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DestinationController : ControllerBase
    {
        readonly string fileLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\data\data.json";

        [HttpGet]
        public IEnumerable<DestinationID> Get()
        {
            JArray arrayOfJson = JArray.Parse(new StreamReader(fileLocation, Encoding.UTF8).ReadToEnd());
            DestinationID[] destinations = arrayOfJson.ToObject<DestinationID[]>();

            var destinationsFilter = destinations.GroupBy(x => new { x.ListingID, x.Company, x.Image_List, x.CategoryID } ).ToList();

            foreach (var groupDestinations in destinationsFilter)
            {
                int place = 0;
                foreach (DestinationID destination in groupDestinations)
                {
                    if (place != 0)
                    {
                        destination.Company = $"{destination.Company} {place}";
                    }
                    place++;
                }
            }

            return destinationsFilter.SelectMany(g => g).ToArray();
        }
    }
}
