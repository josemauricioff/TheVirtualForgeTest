using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Musicalog.MVC.Models.Album;
using RestSharp;

namespace Musicalog.MVC.Controllers
{
    public class AlbumController : Controller
    {
        protected IConfiguration configuration;

        public AlbumController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // GET: AlbumController
        public ActionResult Index()
        {
            string WebApiUri = configuration["WebApiUri"].ToString();

            var client = new RestClient();
            Uri uri = new Uri($"{WebApiUri}/album");
            var req = new RestRequest(uri, Method.GET);

            var response = client.Execute<AlbumIndexModel>(req);

            return View(response.Data);
        }

        // GET: AlbumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlbumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlbumController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: AlbumController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlbumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
