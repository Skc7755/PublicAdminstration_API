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
        /// Afar列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
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
    }
}
