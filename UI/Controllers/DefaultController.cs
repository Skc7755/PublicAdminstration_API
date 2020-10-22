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
        ////////////--------------------------------------《车辆管理》---------------------------------------
        /// <summary>
        /// 车辆信息列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<VehicleInfoModel>> VehicleInfoList(int regattaId, int userId)
        {
            return await new Bll().VehicleInfoList(regattaId, userId);
        }
        /// <summary>
        /// 用车申请
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<CarApplicationModel>> CarApplicationList(int regattaId, int userId)
        {
            return await new Bll().CarApplicationList(regattaId, userId);
        }
        /// <summary>
        /// 汽车保险登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AIRModel>> AIRList(int regattaId, int userId)
        {
            return await new Bll().AIRList(regattaId,userId);

        }
        /// <summary>
        /// 车辆维修保养登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<VMRModel>> VMRList(int regattaId, int userId)
        {
            return await new Bll().VMRList(regattaId, userId);
        }
        /// <summary>
        /// 车辆年检登记表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AIROVModel>> AIROVList(int regattaId, int userId)
        {
            return await new Bll().AIROVList(regattaId,userId);
        }
        /// <summary>
        /// 车辆加油登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<VRRModel>> VRRList(int regattaId, int userId)
        {
            return await new Bll().VRRList(regattaId, userId);
        }
        /// <summary>
        /// 车辆事故登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<VARModel>> VARList(int regattaId, int userId)
        {
            return await new Bll().VARList(regattaId, userId);
        }



        /////////////--------------------------------------《资产管理》---------------------------------
        /// <summary>
        /// 资产归还申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AfarModel>> AfarList(int regattaId, int userId)
        {
            return await _PublicAdmin.AfarList(regattaId,userId);
        }
        /// <summary>
        /// 资产列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<AssetsListModel>> AssetsList(int regattaId, int userId)
        {
            return await _PublicAdmin.AssetsList(regattaId,userId);

        }
        

        /// <summary>
        /// 资产领用申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<CFAModel>> CFAList(int regattaId, int userId)
        {
            return await new Bll().CFAList(regattaId, userId);
        }
        /// <summary>
        /// APA资产采购
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<APAModel>> APAList(int regattaId, int userId)
        {
            return await new Bll().APAList(regattaId, userId);
        }
    }
}