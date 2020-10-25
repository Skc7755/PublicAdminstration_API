using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
    public interface PublicAdmin
    {
        public Task<List<AfarModel>> AfarList(int regattaId, int userId);

        /// <summary>
        /// 获取证照列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<Certification>> GetCertifications(int regattaId, int userId);

        /// <summary>
        /// 获取印章列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<Stamp>> GetStamps(int regattaId, int userId);

        /// <summary>
        /// 获取证照借用信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<License>> GetLicenses(int regattaId, int userId);

        /// <summary>
        /// 用章管理信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<BySeal>> GetBySeals(int regattaId, int userId);

        /// <summary>
        /// 获取申请人下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<Applicant>> GetApplicants(int regattaId, int userId);

        /// <summary>
        /// 获取所属部门下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<Department>> GetDepartments(int regattaId, int userId);

        /// <summary>
        /// 获取证照名称下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<LicenseName>> GetLicenseNames(int regattaId, int userId);

        /// <summary>
        /// 获取印章列表下拉信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<SealName>> GetSealNames(int regattaId, int userId);

        /// <summary>
        /// 证照列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cerId"></param>
        /// <returns></returns>
        public Task<Certification> CerParticulars(int cerId);

        /// <summary>
        /// 印章列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cerId"></param>
        /// <returns></returns>
        public Task<Stamp> StaParticulars(int stId);

        /// <summary>
        /// 证照借用信息详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<License> LicParticulars(int licId);

        /// <summary>
        /// 用章管理信息详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<BySeal> ByParticulars(int byId);

        /// <summary>
        /// 添加证照列表信息
        /// </summary>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> AddCertification(Certification cer);

        /// <summary>
        /// 添加印章列表信息
        /// </summary>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> AddStamp(Stamp sta);

        /// <summary>
        /// 添加证照借用信息
        /// </summary>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> AddLicense(License lic);

        /// <summary>
        /// 添加用章管理信息
        /// </summary>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> AddBySeal(BySeal bys);

        /// <summary>
        /// 删除证照列表信息
        /// </summary>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> DelCertification(int dcerId);

        /// <summary>
        /// 删除证照借用信息
        /// </summary>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> DelCerLicense(int dlicId);

        /// <summary>
        /// 删除印章列表信息
        /// </summary>
        /// <param name="dstId"></param>
        /// <returns></returns>
        public Task<int> DelStamp(int dstId);

        /// <summary>
        /// 删除印章管理信息
        /// </summary>
        /// <param name="dbyId"></param>
        /// <returns></returns>
        public Task<int> DelBySeal(int dbyId);

    }
}
