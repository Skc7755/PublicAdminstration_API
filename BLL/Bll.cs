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

        /// 添加车辆信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<int> AddVehicleInfo(VehicleInfoModel model)
        {
            return await new Dal().AddVehicleInfo(model);
        }
        /// <summary>
        /// 车辆详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<List<VehicleInfoModel>> VehicleInfoDetail(int id)
        {
            return await new Dal().VehicleInfoDetail(id);
        }

        /// <summary>

        public async Task<List<VMRModel>> VMRList(int regattaId, int userId)
        {
            return await new Dal().VMRList(regattaId, userId);
        }

        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<List<CarApplicationModel>> CarApplicationDetail(int id)
        {
            return await new Dal().CarApplicationDetail(id);
        }
        /// <summary>
        /// 汽车保险登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>


        public async Task<List<AIRModel>> AIRList(int regattaId, int userId)
        {
            return await new Dal().AIRList(regattaId, userId);
        }

        /// <summary>

        /// 汽车保险登记详情

        /// 用章管理信息

        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<List<AIRModel>> AIRDetail(int id)
        {
            return await new Dal().AIRDetail(id);
        }
        public async Task<List<AssetsListModel>> AssetsList(int regattaId, int userId)
        {
            return await new Dal().AssetsList(regattaId, userId);
        }

        public async Task<List<VARModel>> VARList(int regattaId, int userId)
        {
            return await new Dal().VARList(regattaId, userId);
        }



        public async Task<List<VehicleInfoModel>> VehicleInfoList(int regattaId, int userId)
        {
            return await new Dal().VehicleInfoList(regattaId, userId);
        }
        public async Task<List<CarApplicationModel>> CarApplicationList(int regattaId, int userId)
        {
            return await new Dal().CarApplicationList(regattaId, userId);
        }

        /// <summary>

        /// 获取申请人下拉列表

        /// 申请人类别表


        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>

        public async Task<List<LoginModel>> Login(string name, string pwd)
        {
            return await new Dal().Login(name, pwd);
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
            return await new Dal().fill(id);
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


        /// <summary>

        /// 车辆维修保养登记详情


        /// 获取部门下拉列表

        /// 用品领用详情


        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<VMRModel>> VMRDetail(int id)
        {
            return await new Dal().VMRDetail(id);
        }
        /// <summary>
        /// 车辆年检登记表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>


        public async Task<List<AIROVModel>> AIROVList(int regattaId, int userId)
        {
            return await new Dal().AIROVList(regattaId, userId);
        }





        /// <summary>

        /// 车辆年检登记详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<AIROVModel>> AIROVDetail(int id)
        {
            return await new Dal().AIROVDetail(id);

        }
        /// <summary>
        /// 车辆加油登记详情


        /// 获取印章名称下拉列表

        /// 用品采购详情


        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>


        public async Task<List<VRRModel>> VRRDetail(int id)
        {
            return await new Dal().VRRDetail(id);
        }
        /// <summary>
        /// 车辆加油登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<VRRModel>> VRRList(int regattaId, int userId)
        {
            return await new Dal().VRRList(regattaId, userId);
        }



        /// <summary>
        /// 车辆事故详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<VARModel>> VARDetail(int id)
        {
            return await new Dal().VARDetail(id);
        }
        //---------------------------------------《资产管理》-----------------------------------------
        /// <summary>
        /// 资产归还申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<AfarModel>> AfarList(int regattaId, int userId)
        {
            return await new Dal().AfarList(regattaId, userId);
        }





        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>

        public async Task<List<AfarModel>> AfarListDetail(int id)
        {
            return await new Dal().AfarListDetail(id);
        }


        public async Task<List<APAModel>> APAList(int regattaId, int userId)
        {
            return await new Dal().APAList(regattaId, userId);

        }

        /// <summary>
        /// 资产详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<List<AssetsListModel>> AssetsListDetail(int id)
        {
            return await new Dal().AssetsListDetail(id);
        }

        /// <summary>
        /// 资产领用申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<CFAModel>> CFAList(int regattaId, int userId)
        {
            return await new Dal().CFAList(regattaId, userId);
        }



        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>


        public async Task<List<CFAModel>> CFAListDetail(int id)
        {

            return await new Dal().CFAListDetail(id);
        }



        /// <summary>
        /// APA资产采购详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<APAModel>> APAListDetail(int id)
        {
            return await new Dal().APAListDetail(id);
        }











        //--------------------------------------------------郑世纪---------------------------------------------------------------------
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
        /// <summary>
        /// 采购新增 郑世纪
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> AddSuppliesprocurement(Suppliesprocurement Sli)
        {
            return await new Dal().AddSuppliesprocurement(Sli);
        }

        //--------------------------------------------------刘浩闯---------------------------------------------------------------------

        /// <summary>
        /// 证照列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Certification>> GetCertifications(int regattaId, int userId)
        {
            return await dal.GetCertifications(regattaId, userId);
        }

        /// <summary>
        /// 获取印章列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Stamp>> GetStamps(int regattaId, int userId)
        {
            return await dal.GetStamps(regattaId, userId);
        }

        /// <summary>
        /// 获取证照借用列表
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

        /// <summary>
        /// 获取申请人下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Applicant>> GetApplicants(int regattaId, int userId)
        {
            return await dal.GetApplicants(regattaId, userId);
        }

        /// <summary>
        /// 获取部门下拉列表
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

        /// <summary>
        /// 获取印章名称下拉列表
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

        /// <summary>
        /// 用章信息详情
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

        /// <summary>
        /// 添加印章列表信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public async Task<int> AddStamp(Stamp sta)
        {
            return await dal.AddStamp(sta);
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

    }
}
