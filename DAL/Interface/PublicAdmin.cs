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
        /// 用品列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Supplieslist>> GetSupplieslist(int regattaId, int userId);
        /// <summary>
        /// 用品列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<Supplieslist> SupplieslistId(int regattaId, int userId, int sllId);
        /// <summary>
        /// 用品类别下拉框
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Category>> GetCategory(int regattaId, int userId);
        /// <summary>
        /// 申请人类别
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Applicant>> GetApplicant(int regattaId, int userId);
        /// <summary>
        /// 所属部门类别
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Department>> GetDepartment(int regattaId, int userId);
        /// <summary>
        /// 用品领用
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Suppliescollect>> GetSuppliescollect(int regattaId, int userId);
        /// <summary>
        /// 用品领用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<Suppliescollect> SuppliescollectId(int regattaId, int userId, int sllId);
        /// <summary>
        /// 用品采购
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Suppliesprocurement>> GetSuppliesprocurement(int regattaId, int userId);
        /// <summary>
        /// 用品采购详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<Suppliesprocurement> SuppliesprocurementId(int regattaId, int userId, int slpId);
        /// <summary>
        /// 用品新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<int> AddSupplieslist(Supplieslist Sll);
        /// <summary>
        /// 领用新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<int> AddSuppliescollect(Suppliescollect Sli);
        /// <summary>
        /// 领用新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<int> AddSuppliesprocurement(Suppliesprocurement Sli);

    }
}
