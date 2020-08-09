using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musicalog.BusinessRules.Interfaces;
using Musicalog.Entity;
using Musicalog.WebApi.ResultEntity;
using Musicalog.WebApi.Util;

namespace Musicalog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        protected IAlbumBusinessRules albumBusinessRules;
        public AlbumController(
            IAlbumBusinessRules albumBusinessRules
            )
        {
            this.albumBusinessRules = albumBusinessRules;
        }

        [HttpGet]
        [Produces("application/json", Type = typeof(BaseResultEntity))]
        public async Task<IActionResult> Get()
        {
            GetAlbumResultEntity result = new GetAlbumResultEntity();
            try
            {
                result.Sucsess = true;
                result.AlbumList = await albumBusinessRules.GetAllAlbuns();
            }
            catch(Exception ex)
            {
                result.Sucsess = false;
                result.ErrorMessage = ErrorHandling.ReturnErrorMessage(ex);
            }

            return Ok(result);
        }

        [HttpPost]
        [Produces("application/json", Type = typeof(BaseResultEntity))]
        public async Task<IActionResult> Post(Album newAlbum)
        {
            PostAlbumResultEntity result = new PostAlbumResultEntity();
            try
            {
                result.Sucsess = true;
                result.Album = await albumBusinessRules.Insert(newAlbum);
            }
            catch (Exception ex)
            {
                result.Sucsess = false;
                result.ErrorMessage = ErrorHandling.ReturnErrorMessage(ex);
            }

            return Ok(result);
        }

        [HttpPut]
        [Produces("application/json", Type = typeof(BaseResultEntity))]
        public async Task<IActionResult> Put(Album album)
        {
            PostAlbumResultEntity result = new PostAlbumResultEntity();
            try
            {
                result.Sucsess = true;
                result.Album = await albumBusinessRules.Update(album);
            }
            catch (Exception ex)
            {
                result.Sucsess = false;
                result.ErrorMessage = ErrorHandling.ReturnErrorMessage(ex);
            }

            return Ok(result);
        }
    }
}
