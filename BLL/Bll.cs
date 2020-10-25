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
        /// 用品列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Supplieslist>> GetSupplieslist(int regattaId, int userId)
        {
            return await new Dal().GetSupplieslist(regattaId, userId);
        }
        /// <summary>
        /// 用品类别表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Category>> GetCategory(int regattaId, int userId)
        {
            return await new Dal().GetCategory(regattaId, userId);
        }
        /// <summary>
        /// 用品列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Supplieslist> SupplieslistId(int regattaId, int userId, int sllId)
        {
            return await new Dal().SupplieslistId(regattaId, userId, sllId);
        }
        /// <summary>
        /// 申请人类别表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
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
        /// 用品领用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Suppliescollect> SuppliescollectId(int regattaId, int userId, int sllId)
        {
            return await new Dal().SuppliescollectId(regattaId, userId, sllId);
        }
        /// <summary>
        /// 用品采购详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Suppliesprocurement> SuppliesprocurementId(int regattaId, int userId, int slpId)
        {
            return await new Dal().SuppliesprocurementId(regattaId, userId, slpId);
        }
        /// <summary>
        /// 用品采购
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Suppliesprocurement>> GetSuppliesprocurement(int regattaId, int userId)
        {
            return await new Dal().GetSuppliesprocurement(regattaId, userId);
        }
        /// <summary>
        /// 用品领用
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Suppliescollect>> GetSuppliescollect(int regattaId, int userId)
        {
            return await new Dal().GetSuppliescollect(regattaId, userId);
        }
        /// <summary>
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
        /// 领用新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> AddSuppliescollect(Suppliescollect Sli)
        {
            return await new Dal().AddSuppliescollect(Sli);
        }
    }
}
