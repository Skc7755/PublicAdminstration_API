using System;
using System.Threading.Tasks;
using Model;
using System.Collections.Generic;
using DAL.Services;

namespace BLL
{
    public class Bll
    {
        /// <summary>
        /// Afar列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<AfarModel>> AfarList(int regattaId, int userId)
        {
            return await new Dal().AfarList(regattaId, userId);
        }

        /// <summary>
        /// 获取证照列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Certification>> GetCertifications(int regattaId, int userId)
        {
            return await new Dal().GetCertifications(regattaId, userId);
        }

        /// <summary>
        /// 获取印章列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Stamp>> GetStamps(int regattaId, int userId)
        {
            return await new Dal().GetStamps(regattaId, userId);
        }

        /// <summary>
        /// 获取证照借用列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<License>> GetLicenses(int regattaId, int userId)
        {
            return await new Dal().GetLicenses(regattaId, userId);
        }

        /// <summary>
        /// 获取申请人下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Applicant>> GetApplicants(int regattaId, int userId)
        {
            return await new Dal().GetApplicants(regattaId, userId);
        }

        /// <summary>
        /// 用章管理信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<BySeal>> GetBySeals(int regattaId, int userId)
        {
            return await new Dal().GetBySeals(regattaId, userId);
        }

        /// <summary>
        /// 获取部门下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Department>> GetDepartments(int regattaId, int userId)
        {
            return await new Dal().GetDepartments(regattaId, userId);
        }

        /// <summary>
        /// 获取证照名称下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<LicenseName>> GetLicenseNames(int regattaId, int userId)
        {
            return await new Dal().GetLicenseNames(regattaId, userId);
        }

        /// <summary>
        /// 获取印章名称下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<SealName>> GetSealNames(int regattaId, int userId)
        {
            return await new Dal().GetSealNames(regattaId, userId);
        }

        /// <summary>
        /// 证照列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Certification> CerParticulars(int cerId)
        {
            return await new Dal().CerParticulars(cerId);
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
            return await new Dal().StaParticulars(stId);
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
            return await new Dal().LicParticulars(licId);
        }

        /// <summary>
        /// 用章信息详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="byId"></param>
        /// <returns></returns>
        public async Task<BySeal> ByParticulars(int byId)
        {
            return await new Dal().ByParticulars(byId);
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
            return await new Dal().AddCertification(cer);
        }

        /// <summary>
        /// 添加印章信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public async Task<int> AddStamp(Stamp sta)
        {
            return await new Dal().AddStamp(sta);
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
            return await new Dal().AddLicense(lic);
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
            return await new Dal().AddBySeal(bys);
        }

        /// <summary>
        /// 删除证照列表信息
        /// </summary>
        /// <param name="cerId"></param>
        /// <returns></returns>
        public async Task<int> DelCertification(int dcerId)
        {
            return await new Dal().DelCertification(dcerId);
        }

        /// <summary>
        /// 删除证照借用信息
        /// </summary>
        /// <param name="dlicId"></param>
        /// <returns></returns>
        public async Task<int> DelCerLicense(int dlicId)
        {
            return await new Dal().DelCerLicense(dlicId);
        }

        /// <summary>
        /// 删除印章列表信息
        /// </summary>
        /// <param name="dstId"></param>
        /// <returns></returns>
        public async Task<int> DelStamp(int dstId)
        {
            return await new Dal().DelStamp(dstId);
        }

        /// <summary>
        /// 删除印章管理信息
        /// </summary>
        /// <param name="dbyId"></param>
        /// <returns></returns>
        public async Task<int> DelBySeal(int dbyId)
        {
            return await new Dal().DelBySeal(dbyId);
        }
    }
}
