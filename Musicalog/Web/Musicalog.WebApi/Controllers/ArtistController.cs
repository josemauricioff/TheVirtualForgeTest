using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musicalog.BusinessRules.Interfaces;
using Musicalog.WebApi.Models;
using Musicalog.WebApi.ResultEntity;
using Musicalog.WebApi.Util;

namespace Musicalog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        protected IArtistBusinessRules artistBusinessRules;
        public ArtistController(
            IArtistBusinessRules artistBusinessRules
            )
        {
            this.artistBusinessRules = artistBusinessRules;
        }

        [HttpGet]
        [Produces("application/json", Type = typeof(BaseResultEntity))]
        public async Task<IActionResult> Get()
        {
            GetArtistResultEntity result = new GetArtistResultEntity();
            try
            {
                result.Success = true;
                var artistList = await artistBusinessRules.GetAllArtists();
                List<ArtistModel> artistModelList = new List<ArtistModel>();
                foreach (var artist in artistList.ToList())
                {
                    artistModelList.Add(new ArtistModel
                    {
                        Id = artist.Id,
                        Description = artist.Description
                    });
                }

                result.ArtistList = artistModelList.AsEnumerable();
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
