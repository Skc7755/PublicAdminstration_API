using System;
using System.Threading.Tasks;
using Model;
using System.Collections.Generic;
using DAL.Services;
using DAL;
namespace BLL
{
    public class Bll
    {

        //实例化DAL
        Dal dal = new Dal();
        /// <summary>
        /// 证照列表


        /// <summary>
        /// 登录


        /// <summary>
        /// 用品列表

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<Certification>> GetCertifications(int regattaId, int userId)
        {
            return await dal.GetCertifications(regattaId, userId);
        }
        public async Task<List<Supplieslist>> GetSupplieslist(int regattaId, int userId)
        {
            return await new Dal().GetSupplieslist(regattaId, userId);

        }

        /// <summary>

        /// 获取印章列表

        /// 用品类别表

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<Stamp>> GetStamps(int regattaId, int userId)
        {
            return await dal.GetStamps(regattaId, userId);
        }
        public async Task<List<Category>> GetCategory(int regattaId, int userId)
        {
            return await new Dal().GetCategory(regattaId, userId);

        }

        /// <summary>

        /// 获取证照借用列表

        /// 用品列表详情

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<License>> GetLicenses(int regattaId, int userId)
        {
            return await dal.GetLicenses(regattaId, userId);
        }

        /// <summary>
        /// 用章管理信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<BySeal>> GetBySeals(int regattaId, int userId)
        {
            return await dal.GetBySeals(regattaId, userId);
        }
        public async Task<Supplieslist> SupplieslistId(int regattaId, int userId, int sllId)
        {
            return await new Dal().SupplieslistId(regattaId, userId, sllId);

        }

        /// <summary>

        /// 获取申请人下拉列表

        /// 申请人类别表


        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>

        public async Task<List<Applicant>> GetApplicants(int regattaId, int userId)
        {
            return await dal.GetApplicants(regattaId, userId);
        }

        public async Task<List<LoginModel>> Login(string name, string pwd)
        {
            return await new  Dal().Login(name, pwd);
        }
        public async Task<List<ConferenceModel>> conferen(int regattaId, int userId)
        {
            return await new Dal().conferen(regattaId, userId);
        }
        public async Task<List<ManageModel>> manage(int regattaId, int userId)
        {
            return await new Dal().manage(regattaId, userId);
        }
        public async Task<ManageModel> fill(int id)
        {
            return await new  Dal().fill(id);
        }
        public async Task<ConferenceModel> fi(int id)
        {
            return await new Dal().fi(id);
        }

        public async Task<int> ManAdd(ManageModel m)
        {
            return await new Dal().ManAdd(m);
        }
        
        public async Task<int> ConAdd(ConferenceModel c)
        {
            return await new Dal().ConAdd(c);
       
        }
        public async Task<List<Applicant>> GetApplicant(int regattaId, int userId)
        {
            return await new Dal().GetApplicant(regattaId, userId);
        }
            /// <summary>
            /// 所属部门类别
            /// </summary>
            /// <param name="regattaId"></param>
            /// <param name="userId"></param>
            /// <returns></returns>
            public async Task<List<Department>> GetDepartment(int regattaId, int userId)
        {
            return await new Dal().GetDepartment(regattaId, userId);

        }

        /// <summary>

        /// 获取部门下拉列表

        /// 用品领用详情

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<Department>> GetDepartments(int regattaId, int userId)
        {
            return await dal.GetDepartments(regattaId, userId);
        }

        /// <summary>
        /// 获取证照名称下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<LicenseName>> GetLicenseNames(int regattaId, int userId)
        {
            return await dal.GetLicenseNames(regattaId, userId);
        }
        public async Task<Suppliescollect> SuppliescollectId(int regattaId, int userId, int sllId)
        {
            return await new Dal().SuppliescollectId(regattaId, userId, sllId);

        }

        /// <summary>

        /// 获取印章名称下拉列表

        /// 用品采购详情

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<SealName>> GetSealNames(int regattaId, int userId)
        {
            return await dal.GetSealNames(regattaId, userId);
        }

        /// <summary>
        /// 证照列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Certification> CerParticulars(int cerId)
        {
            return await dal.CerParticulars(cerId);
        }

        /// <summary>
        /// 印章列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="stId"></param>
        /// <returns></returns>
        public async Task<Stamp> StaParticulars(int stId)
        {
            return await dal.StaParticulars(stId);
        }

        /// <summary>
        /// 证照借用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="licId"></param>
        /// <returns></returns>
        public async Task<License> LicParticulars(int licId)
        {
            return await dal.LicParticulars(licId);
        }
        public async Task<Suppliesprocurement> SuppliesprocurementId(int regattaId, int userId, int slpId)
        {
            return await new Dal().SuppliesprocurementId(regattaId, userId, slpId);
        }

        /// <summary>

        /// 用章信息详情

        /// 用品采购

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="byId"></param>
        /// <returns></returns>

        public async Task<BySeal> ByParticulars(int byId)
        {
            return await dal.ByParticulars(byId);
        }

        /// <summary>
        /// 添加证照列表信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public async Task<int> AddCertification(Certification cer)
        {
            return await dal.AddCertification(cer);
        }
        public async Task<List<Suppliesprocurement>> GetSuppliesprocurement(int regattaId, int userId)
        {
            return await new Dal().GetSuppliesprocurement(regattaId, userId);

        }

        /// <summary>

        /// 添加印章列表信息

        /// 用品领用

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>

        public async Task<int> AddStamp(Stamp sta)
        {
            return await dal.AddStamp(sta);
        }
        public async Task<List<Suppliescollect>> GetSuppliescollect(int regattaId, int userId)
        {
            return await new Dal().GetSuppliescollect(regattaId, userId);

        }
        /// <summary>

        /// 添加证照借用信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public async Task<int> AddLicense(License lic)
        {
            return await dal.AddLicense(lic);
        }
        /// 添加用品
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="Sll"></param>
        /// <returns></returns>
        public async Task<int> AddSupplieslist(Supplieslist Sll)
        {
            return await new Dal().AddSupplieslist(Sll);

        }

        /// <summary>

        /// 添加用章管理信息


        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>

        public async Task<int> AddBySeal(BySeal bys)
        {
            return await dal.AddBySeal(bys);
        }

        /// <summary>
        /// 删除证照列表信息
        /// </summary>
        /// <param name="cerId"></param>
        /// <returns></returns>
        public async Task<int> DelCertification(int dcerId)
        {
            return await dal.DelCertification(dcerId);
        }

        /// <summary>
        /// 删除证照借用信息
        /// </summary>
        /// <param name="dlicId"></param>
        /// <returns></returns>
        public async Task<int> DelCerLicense(int dlicId)
        {
            return await dal.DelCerLicense(dlicId);
        }

        /// <summary>
        /// 删除印章列表信息
        /// </summary>
        /// <param name="dstId"></param>
        /// <returns></returns>
        public async Task<int> DelStamp(int dstId)
        {
            return await dal.DelStamp(dstId);
        }

        /// <summary>
        /// 删除印章管理信息
        /// </summary>
        /// <param name="dbyId"></param>
        /// <returns></returns>
        public async Task<int> DelBySeal(int dbyId)
        {
            return await dal.DelBySeal(dbyId);
        }
        public async Task<int> AddSuppliescollect(Suppliescollect Sli)
        {
            return await new Dal().AddSuppliescollect(Sli);
        }
    }
}
