using System;
using System.Threading.Tasks;
using Model;
using System.Collections.Generic;
using DAL.Services;

namespace BLL
{
    public class Bll
    {
        //--------------------------------------《车辆管理》------------------------------------------
        /// <summary>
        /// 车辆信息列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<VehicleInfoModel>> VehicleInfoList(int regattaId, int userId)
        {
            return await new Dal().VehicleInfoList(regattaId,userId);
        }
        /// <summary>
        /// 用车申请
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<CarApplicationModel>> CarApplicationList(int regattaId, int userId)
        {
            return await new Dal().CarApplicationList(regattaId,userId);
        }
        /// <summary>
        /// 汽车保险登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<AIRModel>> AIRList(int regattaId, int userId)
        {
            return await new Dal().AIRList(regattaId,userId);
        }
        /// <summary>
        /// 车辆维修保养登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<VMRModel>> VMRList(int regattaId, int userId)
        {
            return await new Dal().VMRList(regattaId,userId);
        }
        /// <summary>
        /// 车辆年检登记表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<AIROVModel>> AIROVList(int regattaId, int userId)
        {
            return await new Dal().AIROVList(regattaId,userId);
        }
        /// <summary>
        /// 车辆加油登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<VRRModel>> VRRList(int regattaId, int userId)
        {
            return await new Dal().VRRList(regattaId,userId);
        }
        /// <summary>
        /// 车辆事故登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<VARModel>> VARList(int regattaId, int userId)
        {
            return await new Dal().VARList(regattaId,userId);
        }
            //---------------------------------------《资产管理》-----------------------------------------
            /// <summary>
            /// 资产归还申请列表
            /// </summary>
            /// <param name="regattaId"></param>
            /// <param name="userId"></param>
            /// <returns></returns>
            public async Task<List<AfarModel>> AfarList(int regattaId,int userId)
        {
            return await new Dal().AfarList(regattaId,userId);
        }
        /// <summary>
        /// 资产列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<AssetsListModel>> AssetsList(int regattaId, int userId)
        {
            return await new Dal().AssetsList(regattaId,userId);
        }

        /// <summary>
        /// 资产领用申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<CFAModel>> CFAList(int regattaId, int userId)
        {
            return await new Dal().CFAList(regattaId,userId);
        }
        /// <summary>
        /// APA资产采购
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<APAModel>> APAList(int regattaId, int userId)
        {
            return await new Dal().APAList(regattaId,userId);
        }
        }
}
