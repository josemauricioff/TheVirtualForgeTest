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
    public class AlbumTypeController : ControllerBase
    {
        protected IAlbumTypeBusinessRules albumTypeBusinessRules;
        public AlbumTypeController(
            IAlbumTypeBusinessRules albumTypeBusinessRules
            )
        {
            this.albumTypeBusinessRules = albumTypeBusinessRules;
        }

        [HttpGet]
        [Produces("application/json", Type = typeof(BaseResultEntity))]
        public async Task<IActionResult> Get()
        {
            GetAlbumTypeResultEntity result = new GetAlbumTypeResultEntity();
            try
            {
                result.Sucsess = true;
                result.AlbumTypeList = await albumTypeBusinessRules.GetAllAlbumTypes();
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
