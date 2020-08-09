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
                var albumTypeList = await albumTypeBusinessRules.GetAllAlbumTypes();
                List<AlbumTypeModel> albumTypeModelList = new List<AlbumTypeModel>();
                foreach (var albumType in albumTypeList.ToList())
                {
                    albumTypeModelList.Add(new AlbumTypeModel
                    {
                        Id = albumType.Id,
                        Description = albumType.Description
                    });
                }

                result.AlbumTypeList = albumTypeModelList.AsEnumerable();
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
