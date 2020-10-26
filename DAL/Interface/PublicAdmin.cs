using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
    public interface PublicAdmin
    {

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
        public Task<List<CarApplicationModel>> CarApplicationList(int regattaId, int userId);

        public Task<List<AfarModel>> AfarList(int regattaId, int userId);
        /// <summary>
        /// 汽车保险登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<AIRModel>> AIRList(int regattaId, int userId);
        /// <summary>
        /// 用品列表

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<Certification>> GetCertifications(int regattaId, int userId);

        /// <summary>

        /// 添加车辆信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<int> AddVehicleInfo(VehicleInfoModel model);
        /// <summary>
        /// 车辆详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<List<VehicleInfoModel>> VehicleInfoDetail(int id);
        /// <summary>
        /// 用车申请
        /// 获取印章列表

        Task<List<Supplieslist>> GetSupplieslist(int regattaId, int userId);
        /// <summary>
        /// 资产列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<AssetsListModel>> AssetsList(int regattaId, int userId);



        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<Stamp>> GetStamps(int regattaId, int userId);

        /// <summary>
        /// 获取证照借用列表
        Task<Supplieslist> SupplieslistId(int regattaId, int userId, int sllId);
        /// <summary>

        /// 用车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<List<CarApplicationModel>> CarApplicationDetail(int id);
        /// <summary>
        /// 汽车保险登记

        /// 用品类别下拉框

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<License>> GetLicenses(int regattaId, int userId);

        /// <summary>
        /// 用章管理信息

        Task<List<Category>> GetCategory(int regattaId, int userId);
        /// <summary>
        /// 申请人类别


        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<BySeal>> GetBySeals(int regattaId, int userId);

        /// <summary>

        /// 汽车保险登记详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<List<AIRModel>> AIRDetail(int id);

        /// <summary>
        /// 车辆维修保养登记

        /// 获取申请人下拉列表

        Task<List<Applicant>> GetApplicant(int regattaId, int userId);
        /// <summary>
        /// 所属部门类别


        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<Applicant>> GetApplicants(int regattaId, int userId);

        /// <summary>
        /// 获取部门下拉列表

        Task<List<Department>> GetDepartment(int regattaId, int userId);
        /// <summary>

        /// 车辆维修保养登记详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<VMRModel>> VMRDetail(int id);
        /// <summary>
        /// 车辆年检登记

        /// 用品领用


        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<Department>> GetDepartments(int regattaId, int userId);

        /// <summary>
        /// 获取证照名称下拉列表

        Task<List<Suppliescollect>> GetSuppliescollect(int regattaId, int userId);
        /// <summary>

        /// 车辆年检登记详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<AIROVModel>> AIROVDetail(int id);
        /// <summary>
        /// 车辆加油登记

        /// 用品领用详情

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<LicenseName>> GetLicenseNames(int regattaId, int userId);

        /// <summary>

        /// 车辆加油登记详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<VRRModel>> VRRDetail(int id);
        /// <summary>
        /// 车辆事故登记

        /// 获取印章名称下拉列表

        Task<Suppliescollect> SuppliescollectId(int regattaId, int userId, int sllId);
        /// <summary>
        /// 用品采购

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<VARModel>> VARList(int regattaId,int userId);
        /// <summary>
        /// 车辆事故详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<VARModel>> VARDetail(int id);
      public Task<List<SealName>> GetSealNames(int regattaId, int userId);


        /// <summary>
        /// 证照列表详情

        Task<List<Suppliesprocurement>> GetSuppliesprocurement(int regattaId, int userId);
        /// <summary>
        /// 用品采购详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<Certification> CerParticulars(int cerId);
 
        /// <summary>
        /// 印章列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="stId"></param>
        /// <returns></returns>
        public Task<Stamp> StaParticulars(int stId);

        /// <summary>
        /// 证照借用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="licId"></param>
        /// <returns></returns>
        public Task<License> LicParticulars(int licId);

        /// <summary>
        /// 用章信息详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="byId"></param>
        /// <returns></returns>
        public Task<BySeal> ByParticulars(int byId);

        /// <summary>
        /// 添加证照列表信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> AddCertification(Certification cer);
 
        /// <summary>
        /// 添加印章列表信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> AddStamp(Stamp sta);

        /// <summary>
        /// 添加证照借用信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> AddLicense(License lic);

        /// <summary>

        /// 资产归还详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<AfarModel>> AfarListDetail(int id);
        /// <summary>
        /// 资产列表

        /// 添加用章管理信息

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public Task<int> AddBySeal(BySeal bys);

        /// <summary>
        /// 删除证照列表信息
        /// </summary>
        /// <param name="cerId"></param>
        /// <returns></returns>
        public Task<int> DelCertification(int dcerId);

        /// <summary>
       /// 资产详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<List<AssetsListModel>> AssetsListDetail(int id);
        /// <summary>
        /// 资产领用申请列表

        /// 删除证照借用信息
        /// </summary>
        /// <param name="dlicId"></param>
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

        Task<Suppliesprocurement> SuppliesprocurementId(int regattaId, int userId, int slpId);
        /// <summary>
        /// 用品新增

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<int> AddSupplieslist(Supplieslist Sll);
        /// <summary>
        /// 车辆维修保养登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<VMRModel>> VMRList(int regattaId, int userId);

        public Task<List<AIROVModel>> AIROVList(int regattaId, int userId);

        public Task<List<VRRModel>> VRRList(int regattaId, int userId);
        public Task<List<CFAModel>> CFAList(int regattaId, int userId);

      
        /// <summary>

        /// 资产领用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<CFAModel>> CFAListDetail(int id);
        /// <summary>
        /// APA资产采购申请
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<APAModel>> APAList(int regattaId,int userId);
        /// <summary>
        /// APA资产采购详情

        Task<int> AddSuppliescollect(Suppliescollect Sli);
        /// <summary>
        /// 领用新增

        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Task<List<APAModel>> APAListDetail(int id);

        Task<int> AddSuppliesprocurement(Suppliesprocurement Sli);
        //登录
        public Task<List<LoginModel>> Login(string name, string pwd);
        //显示会议室列表
        public Task<List<ConferenceModel>> conferen(int regattaId, int userId);
        //显示会议室预定列表
        public Task<List<ManageModel>> manage(int regattaId, int userId);
        public Task<ManageModel> fill(int id);
        public Task<ConferenceModel> fi(int id);
        public Task<int> ManAdd(ManageModel m);
        public Task<int> ConAdd(ConferenceModel c);


    }
}
