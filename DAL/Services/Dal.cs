using System;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;
using Model;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using DAL.Interface;

namespace DAL.Services
{
    public class Dal : BaseRepository, PublicAdmin
    {
        /// <summary>
        /// 证照列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<Certification>> GetCertifications(int regattaId, int userId)
        {
            var cer = @"select * from certification c ORDER BY c.C_Id DESC";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<Certification> cerGCg = (await conn.QueryAsync<Certification>(cer, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return cerGCg;
            }
              
        }
        public async Task<List<AfarModel>> AfarList(int regattaId, int userId)
        {
            var cmdText = @"select * from afar";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<AfarModel> memberModel = (await conn
                      .QueryAsync<AfarModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                      .ToList();
                return memberModel;
            }
        }
        /// <summary>
        /// 用品类别表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Category>> GetCategory(int regattaId, int userId)
        {
            var cmdGCg = @"select * from category";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<Category> GetGCg = (await conn.QueryAsync<Category>(cmdGCg, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return GetGCg;
            }
        }
        /// <summary>
        /// 用品列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Supplieslist> SupplieslistId(int regattaId, int userId, int sllId)
        {
            var Backfill = $"select * from Supplieslist where SId='{sllId}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var GetBackfill = await conn
                    .QuerySingleOrDefaultAsync<Supplieslist>(Backfill, new { userId = userId }, commandType: System.Data.CommandType.Text);
                return GetBackfill;
            }
        }
        /// <summary>
        /// 用品列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Supplieslist>> GetSupplieslist(int regattaId, int userId)
        {
            var cmdSll = @"select * from Supplieslist S JOIN Category C ON C.CId = S.CId GROUP BY s.SId DESC";


            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<Supplieslist> GetSll = (await conn.QueryAsync<Supplieslist>(cmdSll, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return GetSll;
            }
        }
        /// <summary>
        /// 申请人类别
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Applicant>> GetApplicant(int regattaId, int userId)
        {
            var cmdAli = @"select * from Applicant";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<Applicant> GetAli = (await conn.QueryAsync<Applicant>(cmdAli, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return GetAli;
            }
        }
        /// <summary>
        /// 所属部门类别
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Department>> GetDepartment(int regattaId, int userId)
        {
            var cmdDpt = @"select * from Department";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<Department> GetDpt = (await conn.QueryAsync<Department>(cmdDpt, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return GetDpt;
            }
        }
        /// <summary>
        /// 用品领用详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Suppliescollect> SuppliescollectId(int regattaId, int userId, int sllId)
        {
            {
                var BfiSll = $"select * from Suppliescollect where SId='{sllId}'";

                //此处可以根据传入的regattaId访问不同的数据
                using (var conn = GetMySqlConnection(regattaId))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        await conn.OpenAsync();
                    }
                    var GetBfiSll = await conn
                   .QuerySingleOrDefaultAsync<Suppliescollect>(BfiSll, new { userId = userId }, commandType: System.Data.CommandType.Text);
                    return GetBfiSll;
                }
            }
        }
        /// <summary>
        /// 用品采购
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Suppliesprocurement>> GetSuppliesprocurement(int regattaId, int userId)
        {
            var cmdSlr = @"SELECT * FROM suppliesprocurement s JOIN applicant a ON a.AId = s.AId JOIN department d ON d.DId = s.DId GROUP BY s.SId DESC";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<Suppliesprocurement> GetSlr = (await conn.QueryAsync<Suppliesprocurement>(cmdSlr, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return GetSlr;
            }
        }
        /// <summary>
        /// 用品采购详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Suppliesprocurement> SuppliesprocurementId(int regattaId, int userId, int slpId)
        {
            {
                var BfiSlp = $"select * from Suppliesprocurement where SId='{slpId}'";

                //此处可以根据传入的regattaId访问不同的数据
                using (var conn = GetMySqlConnection(regattaId))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        await conn.OpenAsync();
                    }
                    var GetBfiSlp = await conn
                   .QuerySingleOrDefaultAsync<Suppliesprocurement>(BfiSlp, new { userId = userId }, commandType: System.Data.CommandType.Text);
                    return GetBfiSlp;
                }
            }
        }
        /// <summary>
        /// 用品领用
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Suppliescollect>> GetSuppliescollect(int regattaId, int userId)
        {
            var cmdSii = @"SELECT * FROM suppliescollect s JOIN applicant a ON a.AId = s.AId JOIN department d ON d.DId = s.DId GROUP BY s.SId DESC";


            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }


              

                List<Suppliescollect> GetSii = (await conn.QueryAsync<Suppliescollect>(cmdSii, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return GetSii;

            }
        }

        /// <summary>
        /// 获取印章列表
        /// 用品新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> AddSupplieslist(Supplieslist Sll)
        {
            var AddSll = $"insert into Supplieslist(SName,CId,Number,Specifications,InventoryQuantity,Company,StorageArea,Administrator,S_Describe,Enclosure)values('{Sll.SName}','{Sll.CId}','{Sll.Number}','{Sll.Specifications}','{Sll.InventoryQuantity}','{Sll.Company}','{Sll.StorageArea}','{Sll.Administrator}','{Sll.S_Describe}','{Sll.Enclosure}')";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var GetAddSll = await conn.ExecuteAsync(AddSll, commandType: System.Data.CommandType.Text);
                return GetAddSll;
            }
        }
        /// <summary>
        /// 领用新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> AddSuppliescollect(Suppliescollect Sli)
        {
            var AddSli = $"insert into Suppliescollect(ThemeName,EndTime,AId,DId,ApplicationTime,ReceivedQuantity,Remarks)values('{Sli.ThemeName}','{Sli.EndTime}','{Sli.AId}','{Sli.DId}','{Sli.ApplicationTime}','{Sli.ReceivedQuantity}','{Sli.Remarks}')";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var GetAddSli = await conn.ExecuteAsync(AddSli, commandType: System.Data.CommandType.Text);
                return GetAddSli;
            }
        }
        /// <summary>
        /// 采购新增
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> AddSuppliesprocurement(Suppliesprocurement Sli)
        {
            var AddSlm = $"insert into Suppliesprocurement(ThemeName,EndTime,AId,DId,ApplicationTime,ProcurementQuantity,Remarks)values('{Sli.ThemeName}','{Sli.EndTime}','{Sli.AId}','{Sli.DId}','{Sli.ApplicationTime}','{Sli.ProcurementQuantity}','{Sli.Remarks}')";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var GetAddSlm = await conn.ExecuteAsync(AddSlm, commandType: System.Data.CommandType.Text);
                return GetAddSlm;
            }
        }

        //public Task<Paging> GetPaging(string SName, int page = 1, int limit = 6)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// 印章列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Stamp>> GetStamps(int regattaId, int userId)
        {
            var sta = @"select * from stamp s ORDER BY s.S_Id DESC";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<Stamp> staModel = (await conn.QueryAsync<Stamp>(sta, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return staModel;
            }
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<LoginModel>> Login(string name, string pwd)
        {

            var deng = $"select count(*) from login where UserName='{name}' and UserPassWord='{pwd}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var logins = conn
                 .Query<LoginModel>(deng, commandType: System.Data.CommandType.Text)
                 .ToList();
                return logins;
            }

        }

        /// <summary>
        /// 获取证照借用列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<License>> GetLicenses(int regattaId, int userId)
        {
            var lic = @"select * from license l join applicant a on l.A_Id=a.AId join department d on d.DId=l.D_Id JOIN licensename ln on ln.LN_Id=l.LN_Id ORDER BY l.L_Id DESC";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<License> licModel = (await conn.QueryAsync<License>(lic, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return licModel;
            }
        }

        /// <summary>
        /// 用章管理信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<BySeal>> GetBySeals(int regattaId, int userId)
        {
            var bys = @"SELECT * from byseal b join applicant a on a.AId=b.A_Id join department d on d.DId=b.D_Id join sealname sn on sn.SN_Id=b.SN_Id ORDER BY b.SN_Id DESC";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<BySeal> bysModel = (await conn.QueryAsync<BySeal>(bys, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return bysModel;
            }
        }

        /// <summary>
        /// 获取申请人下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Applicant>> GetApplicants(int regattaId, int userId)
        {
            var appl = @"SELECT * from applicant";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<Applicant> applModel = (await conn.QueryAsync<Applicant>(appl, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return applModel;
            }
        }

        /// <summary>
        /// 获取部门下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Department>> GetDepartments(int regattaId, int userId)
        {
            var depa = @"select * from Department";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }


                List<Department> depaModel = (await conn.QueryAsync<Department>(depa, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return depaModel;


            }
        }

        /// <summary>
        /// 获取证照名称下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<LicenseName>> GetLicenseNames(int regattaId, int userId)
        {
            var lic = @"SELECT * from licensename";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<LicenseName> licModel = (await conn.QueryAsync<LicenseName>(lic, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return licModel;
            }
        }

        /// <summary>
        /// 获取印章名称下拉列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<SealName>> GetSealNames(int regattaId, int userId)
        {
            var seal = @"select * from SealName";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                List<SealName> sealModel = (await conn.QueryAsync<SealName>(seal, new { userId = userId }, commandType: System.Data.CommandType.Text)).ToList();
                return sealModel;
            }
        }

        /// <summary>
        /// 证照列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Certification> CerParticulars(int cerId)
        {
            var lic = $"select * from certification where C_Id='{cerId}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }


                var licModel = await conn
                   .QuerySingleOrDefaultAsync<Certification>(lic, commandType: System.Data.CommandType.Text);
                return licModel;

            }
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
            var stal = $"select * from stamp where S_Id='{stId}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var stalModel = await conn
                   .QuerySingleOrDefaultAsync<Stamp>(stal, commandType: System.Data.CommandType.Text);
                return stalModel;

                

            }
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

                    var licl = $"select * from License l where L_Id ='{licId}'";

                    //此处可以根据传入的regattaId访问不同的数据
                    using (var conn = GetMySqlConnection())
                    {
                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            await conn.OpenAsync();
                        }

                        var liclModel = await conn
                            .QuerySingleOrDefaultAsync<License>(licl, commandType: System.Data.CommandType.Text);
                        return liclModel;
                    }
                }

        public async Task<int> ManAdd(ManageModel m)
        {
            var manText = $"insert into Management(Man_Theme,Man_Applicant,Man_Department,Man_ApplicatTime,Man_Reserve,Man_StartTime,Man_EndTime,Man_Reasons,Man_Remarks,Man_Actual,Man_Enclosure)values('{m.Man_Theme}','{m.Man_Applicant}','{m.Man_Department}','{m.Man_ApplicatTime}','{m.Man_Reserve}','{m.Man_StartTime}','{m.Man_EndTime}','{m.Man_Reasons}','{m.Man_Remarks}','{m.Man_Actual}','{m.Man_Enclosure}')";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var mantian = await conn.ExecuteAsync(manText, commandType: System.Data.CommandType.Text);
                return mantian;
            }
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
            var licl = $"SELECT * FROM byseal WHERE B_Id='{byId}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var liclModel = await conn
                    .QuerySingleOrDefaultAsync<BySeal>(licl, commandType: System.Data.CommandType.Text);
                return liclModel;
            }
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
            var Addcer = $"INSERT INTO certification (C_Name,C_Number,C_Authority,C_Date,C_Review,C_Validity,C_Annual,C_Loaner,C_Manager,C_Description) VALUES('{cer.C_Name}','{cer.C_Number}','{cer.C_Authority}','{cer.C_Date}',{cer.C_Review},{cer.C_Validity},'{cer.C_Annual}','{cer.C_Loaner}','{cer.C_Manager}','{cer.C_Description}')";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var AddcerModel = await conn.ExecuteAsync(Addcer, commandType: System.Data.CommandType.Text);
                return AddcerModel;
            }
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
            var Addsta = $"INSERT INTO stamp (S_Name,S_Commissioning,S_Loaner,S_Manager,S_Description) VALUES('{sta.S_Name}','{sta.S_Commissioning}','{sta.S_Loaner}','{sta.S_Manager}','{sta.S_Description}')";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var AddstaModel = await conn.ExecuteAsync(Addsta, commandType: System.Data.CommandType.Text);
                return AddstaModel;
            }
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
            var Addlic = $"INSERT INTO license (L_Matter,L_EndTime,A_Id,D_Id,L_ApplicationTime,LN_Id,L_Purpose,L_AdvanceTime,L_ReturenTime,L_Information) VALUES('{lic.L_Matter}','{lic.L_EndTime}',{lic.A_Id},{lic.D_Id},'{lic.L_ApplicationTime}',{lic.LN_Id},'{lic.L_Purpose}','{lic.L_AdvanceTime}','{lic.L_ReturenTime}','{lic.L_Information}')";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var AddlicModel = await conn.ExecuteAsync(Addlic, commandType: System.Data.CommandType.Text);
                return AddlicModel;
            }
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
            var Addbys = $"INSERT INTO byseal (B_Matter,B_EndTime,A_Id,D_Id,B_ApplicationTime,SN_Id,B_Purpose,B_File,B_Used,B_AdvanceTime,B_ReturenTime,B_Information) VALUES('{bys.B_Matter}','{bys.B_EndTime}',{bys.A_Id},{bys.D_Id},'{bys.B_ApplicationTime}',{bys.SN_Id},'{bys.B_Purpose}','{bys.B_File}',{bys.B_Used},'{bys.B_AdvanceTime}','{bys.B_ReturenTime}','{bys.B_Information}')";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var AddbysModel = await conn.ExecuteAsync(Addbys, commandType: System.Data.CommandType.Text);
                return AddbysModel;
            }
        }
        /// <summary>
        /// 删除证照列表信息
        /// </summary>
        /// <param name="cerId"></param>
        /// <returns></returns>
        public async Task<int> DelCertification(int dcerId)
        {
            var Addbys = $"delete from Certification where C_Id='{dcerId}'";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var AddbysModel = await conn.ExecuteAsync(Addbys, commandType: System.Data.CommandType.Text);
                return AddbysModel;
            }
        }
        /// <summary>
        /// 删除证照借用信息
        /// </summary>
        /// <param name="dlicId"></param>
        /// <returns></returns>
        public async Task<int> DelCerLicense(int dlicId)
        {
            var Addbys = $"delete from License where L_Id='{dlicId}'";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var AddbysModel = await conn.ExecuteAsync(Addbys, commandType: System.Data.CommandType.Text);
                return AddbysModel;
            }
        }
        /// <summary>
        /// 删除印章列表信息
        /// </summary>
        /// <param name="dstId"></param>
        /// <returns></returns>
        public async Task<int> DelStamp(int dstId)
        {
            var Addbys = $"delete from Stamp where S_Id='{dstId}'";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var AddbysModel = await conn.ExecuteAsync(Addbys, commandType: System.Data.CommandType.Text);
                return AddbysModel;
            }
        }

        /// <summary>
        /// 删除印章管理信息
        /// </summary>
        /// <param name="dbyId"></param>
        /// <returns></returns>
        public async Task<int> DelBySeal(int dbyId)
        {
            var Addbys = $"delete from BySeal where B_Id='{dbyId}'";
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var AddbysModel = await conn.ExecuteAsync(Addbys, commandType: System.Data.CommandType.Text);
                return AddbysModel;
            }
        }

        public async Task<List<ConferenceModel>> conferen(int regattaId, int userId)
        {

            var confer = @"select * from conference c join state s on  c.Con_State =s.SID";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var conModel = conn
                 .Query<ConferenceModel>(confer, new { userId = userId }, commandType: System.Data.CommandType.Text)
                 .ToList();
                return conModel;
            }

        }

        public async Task<List<ManageModel>> manage(int regattaId, int userId)
        {

            var man = @"SELECT * from management m join reserve r on m.Man_Reserve = r.RID join department d on m.Man_Department = d.DId";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var manages = conn
                 .Query<ManageModel>(man, new { userId = userId }, commandType: System.Data.CommandType.Text)
                 .ToList();
                return manages;
            }
        }
        public async Task<ManageModel> fill(int id)
        {

            var tian = $"SELECT* from management m join reserve r on m.Man_Reserve = r.RID join department d on m.Man_Department = d.DId where m.Man_ID='{id}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var ft = await conn.QueryFirstOrDefaultAsync<ManageModel>(tian, commandType: System.Data.CommandType.Text);

                return ft;
            }
        }

        public async Task<ConferenceModel> fi(int id)
        {

            var fan = $"select * from conference c join state s on  c.Con_State =s.SID where c.Con_ID='{id}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var fantian = await conn.QueryFirstOrDefaultAsync<ConferenceModel>(fan, commandType: System.Data.CommandType.Text);
                return fantian;
            }
        }

        public async Task<int> ConAdd(ConferenceModel c)

        {

            var conText = $"INSERT into conference(Con_Name,Con_No,Con_Capacity,Con_Position,Con_Interiors,Con_Admin,Con_State,Con_Describe,Con_Attach,Con_Picture)VALUES('{c.Con_Name}', '{c.Con_No}', '{c.Con_Capacity}', '{c.Con_Position}', '{c.Con_Interiors}', '{c.Con_Admin}', '{c.Con_State}','{c.Con_Describe}', '{c.Con_Attach}', '{c.Con_Picture}')";
            ;
            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var contian = await conn.ExecuteAsync(conText, commandType: System.Data.CommandType.Text);
                return contian;
            }
        }
    }
}
