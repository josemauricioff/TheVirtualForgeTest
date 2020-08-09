using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musicalog.BusinessRules.Interfaces;
using Musicalog.Entity;
using Musicalog.WebApi.ResultEntity;
using Musicalog.WebApi.Util;
using Musicalog.WebApi.Models;
using System.Collections.Generic;

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
                result.Success = true;
                var albumList = await albumBusinessRules.GetAllAlbuns();
                List<GetAlbumModel> getAlbumModelList = new List<GetAlbumModel>();
                foreach (var album in albumList.ToList())
                {
                    getAlbumModelList.Add(new GetAlbumModel
                    {
                        Name = album.Description,
                        Artist = album.Artist.Description,
                        Type = album.Albumtype.Description,
                        Stock = album.Stock
                    });
                }

                result.AlbumList = getAlbumModelList.AsEnumerable();
            }
            catch (Exception ex)
            {
                result.Success = false;
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
                result.Success = true;
                var album = await albumBusinessRules.Insert(newAlbum);

                result.Album = new AlbumModel
                {
                    Id = album.Id,
                    Description = album.Description,
                    AlbumTypeId = album.AlbumTypeId,
                    ArtistId = album.ArtistId,
                    Stock = album.Stock,
                    Label = album.Label
                };
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ErrorHandling.ReturnErrorMessage(ex);
            }

            return Ok(result);
        }

        [HttpPut]
        [Produces("application/json", Type = typeof(BaseResultEntity))]
        public async Task<IActionResult> Put(Album updatedAlbum)
        {
            PostAlbumResultEntity result = new PostAlbumResultEntity();
            try
            {
                result.Success = true;
                var album = await albumBusinessRules.Update(updatedAlbum);

                result.Album = new AlbumModel
                {
                    Id = album.Id,
                    Description = album.Description,
                    AlbumTypeId = album.AlbumTypeId,
                    ArtistId = album.ArtistId,
                    Stock = album.Stock,
                    Label = album.Label
                };
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ErrorHandling.ReturnErrorMessage(ex);
            }

            return Ok(result);
        }
    }
}
