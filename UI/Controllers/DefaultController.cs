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
            return await _PublicAdmin.AfarList(regattaId, userId);
        }

        /// <summary>
        /// 证照列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Certification>> GetCertifications(int regattaId, int userId, string cername, int pageindex, int pagesize)
        {
            List<Certification> list = await _PublicAdmin.GetCertifications(regattaId, userId);
            //根据名称模糊查询
            if (!string.IsNullOrEmpty(cername))
            {
                list = list.Where(s => s.C_Name.Contains(cername)).ToList();
            }
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }

        /// <summary>
        /// 获取印章列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Stamp>> GetStamps(int regattaId, int userId, int pageindex, int pagesize)
        {
            List<Stamp> list = await _PublicAdmin.GetStamps(regattaId, userId);
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }

        /// <summary>
        /// 获取证照借用列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<License>> GetLicenses(int regattaId, int userId, string licmatter, string depar, int pageindex, int pagesize)
        {
            List<License> list = await _PublicAdmin.GetLicenses(regattaId, userId);
            //根据主题模糊查询
            if (!string.IsNullOrEmpty(licmatter))
            {
                list = list.Where(s => s.L_Matter.Contains(licmatter)).ToList();
            }
            //根据部门准确查找
            if (!string.IsNullOrEmpty(depar))
            {
                list = list.Where(s => s.DName.Equals(depar)).ToList();
            }
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
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

        /// <summary>
        /// 获取申请人下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Applicant>> GetApplicants(int regattaId, int userId)
        {
            return await _PublicAdmin.GetApplicants(regattaId, userId);
        }

        /// <summary>
        /// 获取部门下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Department>> GetDepartments(int regattaId, int userId)
        {
            return await _PublicAdmin.GetDepartments(regattaId, userId);
        }

        /// <summary>
        /// 获取证照名称下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<LicenseName>> GetLicenseNames(int regattaId, int userId)
        {
            return await _PublicAdmin.GetLicenseNames(regattaId, userId);
        }

        /// <summary>
        /// 获取印章名称下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<SealName>> GetSealNames(int regattaId, int userId)
        {
            return await _PublicAdmin.GetSealNames(regattaId, userId);
        }

        /// <summary>
        /// 证照列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Certification> CerParticulars(int cerId)
        {
            return await _PublicAdmin.CerParticulars(cerId);
        }

        /// <summary>
        /// 印章列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="stId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Stamp> StaParticulars(int stId)
        {
            return await _PublicAdmin.StaParticulars(stId);
        }

        /// <summary>
        /// 证照借用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="licId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<License> LicParticulars(int licId)
        {
            return await _PublicAdmin.LicParticulars(licId);
        }

        /// <summary>
        /// 用章信息详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="byId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<BySeal> ByParticulars(int byId)
        {
            return await _PublicAdmin.ByParticulars(byId);
        }

        /// <summary>
        /// 添加证照列表信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> AddCertification([FromBody] Certification cer)
        {
            return await _PublicAdmin.AddCertification(cer);
        }

        /// <summary>
        /// 添加印章列表信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> AddStamp([FromBody] Stamp sta)
        {
            return await _PublicAdmin.AddStamp(sta);
        }

        /// <summary>
        /// 添加证照借用信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> AddLicense([FromBody] License lic)
        {
            return await _PublicAdmin.AddLicense(lic);
        }

        /// <summary>
        /// 添加用章管理信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> AddBySeal([FromBody] BySeal bys)
        {
            return await _PublicAdmin.AddBySeal(bys);
        }

        /// <summary>
        /// 删除证照列表信息
        /// </summary>
        /// <param name="cerId"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> DelCertification(int dcerId)
        {
            return await _PublicAdmin.DelCertification(dcerId);
        }

        /// <summary>
        /// 删除证照借用信息
        /// </summary>
        /// <param name="dlicId"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> DelCerLicense(int dlicId)
        {
            return await _PublicAdmin.DelCerLicense(dlicId);
        }

        /// <summary>
        /// 删除印章列表信息
        /// </summary>
        /// <param name="dstId"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> DelStamp(int dstId)
        {
            return await _PublicAdmin.DelStamp(dstId);
        }

        /// <summary>
        /// 删除印章管理信息
        /// </summary>
        /// <param name="dbyId"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> DelBySeal(int dbyId)
        {
            return await _PublicAdmin.DelBySeal(dbyId);
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