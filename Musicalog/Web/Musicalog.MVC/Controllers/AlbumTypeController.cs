using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Musicalog.MVC.Models.AlbumType;
using RestSharp;

namespace Musicalog.MVC.Controllers
{
    public class AlbumTypeController : Controller
    {
        protected IConfiguration configuration;

        public AlbumTypeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetAllAlbumTypes()
        {
            string WebApiUri = configuration["WebApiUri"].ToString();

            var client = new RestClient();
            Uri uri = new Uri($"{WebApiUri}/AlbumType");
            var req = new RestRequest(uri, Method.GET);

            var response = client.Execute<GetAllAlbumTypeModel>(req);

            return Ok(response.Data);
        }
    }
}
