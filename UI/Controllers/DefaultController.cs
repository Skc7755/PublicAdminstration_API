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


        [HttpPost]
        /// <summary>
       /// 添加车辆信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<int> AddVehicleInfo([FromBody] VehicleInfoModel model)
        {
            return await new Bll().AddVehicleInfo(model);
        }
        /// <summary>
        /// 车辆详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<VehicleInfoModel>> VehicleInfoDetail(int id)
        {
            return await new Bll().VehicleInfoDetail(id);
        }
        /// <summary>
        /// 用车申请

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

        /// 用车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<CarApplicationModel>> CarApplicationDetail(int id)
        {
            return await new Bll().CarApplicationDetail(id);
        }
        /// <summary>
        /// 汽车保险登记


        /// <summary>

        /// 汽车保险登记详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AIRModel>> AIRDetail(int id)
        {
            return await new Bll().AIRDetail(id);
        }
        /// <summary>
        /// 车辆维修保养登记


        /// 车辆维修保养登记详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<VMRModel>> VMRDetail(int id)
        {
            return await new Bll().VMRDetail(id);
        }
        /// <summary>
        /// 车辆年检登记表
        /// <summary>

        /// 车辆年检登记详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AIROVModel>> AIROVDetail(int id)
        {
            return await new Bll().AIROVDetail(id);

        }
        /// <summary>
        /// 车辆加油登记

  
        /// <summary>

        /// 车辆加油登记详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<VRRModel>> VRRDetail(int id)
        {
            return await new Bll().VRRDetail(id);
        }
        /// <summary>
        /// 车辆事故登记

 

        /// <summary>
        /// 车辆事故详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
       [HttpGet]
        public async Task<List<VARModel>> VARDetail(int id)
        {
            return await new Bll().VARDetail(id);
        }




        /////////////--------------------------------------《资产管理》---------------------------------


        /// <summary>

        /// 资产归还详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AfarModel>> AfarListDetail(int id)
        {
            return await new Bll().AfarListDetail(id);
        }
        /// <summary>
        /// 资产列表


        [HttpGet]
        public async Task<List<VehicleInfoModel>> VehicleInfoList(int regattaId, int userId)
        {
            return await new Bll().VehicleInfoList(regattaId, userId);
        }
        [HttpGet]
        public async Task<List<CarApplicationModel>> CarApplicationList(int regattaId, int userId)
        {
            return await new Bll().CarApplicationList(regattaId, userId);
        }
        [HttpGet]
        public async Task<List<AIRModel>> AIRList(int regattaId, int userId)
        {
            return await new Bll().AIRList(regattaId,userId);
        }
        [HttpGet]
        public async Task<List<VMRModel>> VMRList(int regattaId, int userId)
        {
            return await new Bll().VMRList(regattaId,userId);
        }
        /// <summary>
        /// 资产详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AssetsListModel>> AssetsListDetail(int id)
        {
            return await new Bll().AssetsListDetail(id);
        }
        [HttpGet]
        public async Task<List<AIROVModel>> AIROVList(int regattaId, int userId)
        {
            return await new Bll().AIROVList(regattaId,userId);
        }
        [HttpGet]
        public async Task<List<VRRModel>> VRRList(int regattaId, int userId)
        {
            return await new Bll().VRRList(regattaId,userId);
        }
        [HttpGet]
        public async Task<List<VARModel>> VARList(int regattaId, int userId)
        {
            return await new Bll().VARList(regattaId, userId);
        }
       


        [HttpGet]
        public async Task<List<APAModel>> APAList(int regattaId, int userId)
        {
            return await new Bll().APAList(regattaId, userId);

        }
        [HttpGet]
        public async Task<List<AssetsListModel>> AssetsList(int regattaId, int userId)
        {
            return await new Bll().AssetsList(regattaId, userId);
        }
        [HttpGet]
        public async Task<List<CFAModel>> CFAList(int regattaId, int userId)
        {
            return await new Bll().CFAList(regattaId,userId);
        }


        /// <summary>

        /// 资产领用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<CFAModel>> CFAListDetail(int id)
        {

            return await new Bll().CFAListDetail(id);
        }
        
        /// <summary>
        /// APA资产采购详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<APAModel>> APAListDetail(int id)
        {
            return await new Bll().APAListDetail(id);
        }




     
     

       
















        //--------------------------------------------------郑世纪---------------------------------------------------------------------

        /// <summary>
        /// 用品列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="Name"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Supplieslist>> GetSupplieslist(int regattaId, int userId, string Name, int pageindex, int pagesize)
        {
            List<Supplieslist> list = await _PublicAdmin.GetSupplieslist(regattaId, userId);
            if (!string.IsNullOrEmpty(Name))
            {
                list = list.Where(s => s.SName.Contains(Name)).ToList();
            }
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
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
        /// 申请人类别下拉框 郑世纪
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
        /// 所属部门类别下拉框 郑世纪
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



        //--------------------------------------------------刘浩闯---------------------------------------------------------------------

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







    }
}