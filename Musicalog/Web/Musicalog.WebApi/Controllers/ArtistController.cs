using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Musicalog.BusinessRules.Interfaces;
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
                result.Sucsess = true;
                result.ArtistList = await artistBusinessRules.GetAllArtists();
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
