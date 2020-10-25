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
        [Route("/api/Login")]
        [HttpGet]
        public async Task<List<LoginModel>> Login(string name,string pwd)
        {
            return await _PublicAdmin.Login(name,pwd);
        }
        [HttpGet]
        public async Task<List<ConferenceModel>> conferen(int regattaId, int userId)
        {
            return await _PublicAdmin.conferen(regattaId, userId);
        }
        [HttpGet]
        public async Task<List<ManageModel>> manage(int regattaId, int userId)
        {
            return await _PublicAdmin.manage(regattaId, userId);
        }
        [HttpGet]
        public async Task<ManageModel> fill(int id)
        {
            return await _PublicAdmin.fill(id);
        }
        [HttpGet]
        public async Task<ConferenceModel> fi( int id)
        {
            return await _PublicAdmin.fi( id);
        }
        [HttpPost]
        public async Task<int> ManAdd([FromBody]ManageModel m)
        {
            return await _PublicAdmin.ManAdd(m);
        }
        [HttpPost]
        public async Task<int> ConAdd([FromBody]ConferenceModel c)
        {
            return await _PublicAdmin.ConAdd(c);
        }


    }
}