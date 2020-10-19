using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using BLL;
using DAL.Interface;
namespace UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private PublicAdmin _PublicAdmin;
        public DefaultController(PublicAdmin publicAdmin)
        {
            _PublicAdmin = publicAdmin;
        }
        /// <summary>
        /// Afar列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AfarModel>> AfarList(int regattaId, int userId)
        {
            return await _PublicAdmin.AfarList(regattaId,userId);
        }
    }
}