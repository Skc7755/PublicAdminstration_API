using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
   public interface PublicAdmin
    {
        //------------------------《车辆管理》------------------------------------------

        /// <summary>
        /// 车辆信息列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<VehicleInfoModel>> VehicleInfoList(int regattaId, int userId);
        /// <summary>
        /// 用车申请
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<CarApplicationModel>> CarApplicationList(int regattaId,int userId);
        /// <summary>
        /// 汽车保险登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<AIRModel>> AIRList(int regattaId, int userId);
        /// <summary>
        /// 车辆维修保养登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<VMRModel>> VMRList(int regattaId,int userId);
        /// <summary>
        /// 车辆年检登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<AIROVModel>> AIROVList(int regattaId,int userId);
        /// <summary>
        /// 车辆加油登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<VRRModel>> VRRList(int regattaId,int userId);
        /// <summary>
        /// 车辆事故登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<VARModel>> VARList(int regattaId,int userId);


        ////////////////////////////////////////////////////////////////////////////////
        //------------------------《资产管理》------------------------------------------
        /// <summary>
        /// 资产归还申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<AfarModel>> AfarList(int regattaId, int userId);
        /// <summary>
        /// 资产列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<AssetsListModel>> AssetsList(int regattaId, int userId);
        /// <summary>
        /// 资产领用申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<CFAModel>> CFAList(int regattaId, int userId);
        /// <summary>
        /// APA资产采购申请
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<APAModel>> APAList(int regattaId,int userId);
    }
}
