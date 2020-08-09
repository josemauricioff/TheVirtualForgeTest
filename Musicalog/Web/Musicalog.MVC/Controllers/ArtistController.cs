using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Musicalog.MVC.Models;
using Musicalog.MVC.Models.Artist;
using RestSharp;

namespace Musicalog.MVC.Controllers
{
    public class ArtistController : Controller
    {
        protected IConfiguration configuration;

        public ArtistController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetAllArtists()
        {
            string WebApiUri = configuration["WebApiUri"].ToString();

            var client = new RestClient();
            Uri uri = new Uri($"{WebApiUri}/artist");
            var req = new RestRequest(uri, Method.GET);

            var response = client.Execute<GetAllArtistsModel>(req);

            return Ok(response.Data);
        }
    }
}
