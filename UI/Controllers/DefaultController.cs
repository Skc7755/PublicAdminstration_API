using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using BLL;
using DAL.Interface;
using Newtonsoft.Json;

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
        /// 证照列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
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



        /// <summary>
        /// Afar列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AfarModel>> AfarList(int regattaId, int userId)
        {
            return await _PublicAdmin.AfarList(regattaId, userId);
        }
        /// <summary>
        /// 用品列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Supplieslist>> GetSupplieslist(int regattaId, int userId, string Name, int pageindex, int pagesize)
        {
            List<Supplieslist> list = await _PublicAdmin.GetSupplieslist(regattaId, userId);

            //string sql = JsonConvert.SerializeObject(new { count = 100, code = 0, msg = "", data = list });
            if (!string.IsNullOrEmpty(Name))
            {
                list = list.Where(s => s.SName.Contains(Name)).ToList();
            }
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }
        /// <summary>
        /// 用品类别表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Category>> GetCategory(int regattaId, int userId)
        {
            return await _PublicAdmin.GetCategory(regattaId, userId);
        }
        /// <summary>
        /// 用品列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Supplieslist> SupplieslistId(int regattaId, int userId, int sllId)
        {
            return await _PublicAdmin.SupplieslistId(regattaId, userId, sllId);
        }
        /// <summary>
        /// 申请人类别表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Applicant>> GetApplicant(int regattaId, int userId)
        {
            return await _PublicAdmin.GetApplicant(regattaId, userId);
        }
        /// <summary>
        /// 所属部门类别
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Department>> GetDepartment(int regattaId, int userId)
        {
            return await _PublicAdmin.GetDepartment(regattaId, userId);
        }
        /// <summary>
        /// 用品领用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Suppliescollect> SuppliescollectId(int regattaId, int userId, int sllId)
        {
            return await _PublicAdmin.SuppliescollectId(regattaId, userId, sllId);
        }
        /// <summary>
        /// 用品采购详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Suppliesprocurement> SuppliesprocurementId(int regattaId, int userId, int slpId)
        {
            return await _PublicAdmin.SuppliesprocurementId(regattaId, userId, slpId);
        }
        /// <summary>
        /// 用品采购
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Suppliesprocurement>> GetSuppliesprocurement(int regattaId, int userId, string SName, int pageindex, int pagesize)
        {
            List<Suppliesprocurement> list = await _PublicAdmin.GetSuppliesprocurement(regattaId, userId);
            if (!string.IsNullOrEmpty(SName))
            {
                list = list.Where(s => s.ThemeName.Contains(SName)).ToList();
            }
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }
        /// <summary>
        /// 用品领用
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Suppliescollect>> GetSuppliescollect(int regattaId, int userId, string TName, int pageindex, int pagesize)
        {
            List<Suppliescollect> list = await _PublicAdmin.GetSuppliescollect(regattaId, userId);
            if (!string.IsNullOrEmpty(TName))
            {
                list = list.Where(s => s.ThemeName.Contains(TName)).ToList();
            }
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }
        /// <summary>
        /// 用品新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> AddSupplieslist([FromBody]Supplieslist Sll)
        {
            return await _PublicAdmin.AddSupplieslist(Sll);
        }
        /// <summary>
        /// 领用新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> AddSuppliescollect([FromBody]Suppliescollect Sli)
        {
            return await _PublicAdmin.AddSuppliescollect(Sli);
        }
        /// <summary>
        /// 采购新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> AddSuppliesprocurement(Suppliesprocurement Sli)
        {
            return await _PublicAdmin.AddSuppliesprocurement(Sli);
        }
        /// <summary>
        /// 用章管理信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<BySeal>> GetBySeals(int regattaId, int userId, string bymatter, string depar, int pageindex, int pagesize)
        {
            List<BySeal> list = await _PublicAdmin.GetBySeals(regattaId, userId);
            //根据主题模糊查询
            if (!string.IsNullOrEmpty(bymatter))
            {
                list = list.Where(s => s.B_Matter.Contains(bymatter)).ToList();
            }
            //根据部门准确查找
            if (!string.IsNullOrEmpty(depar))
            {
                list = list.Where(s => s.DName.Equals(depar)).ToList();
            }
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }
    }
}