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
    public class Dal:BaseRepository,PublicAdmin
    {
        //-------------------------------------《车辆管理》-----------------------------------------
        /// <summary>
        /// 车辆信息列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<VehicleInfoModel>> VehicleInfoList(int regattaId, int userId)
        {
            var cmdText = @"select * from vehicleinfo";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<VehicleInfoModel> memberModel = (await conn
                    .QueryAsync<VehicleInfoModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }

        }
        /// <summary>
        /// 用车申请
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<CarApplicationModel>> CarApplicationList(int regattaId, int userId)
        {
            var cmdText = "select * from carapplication";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<CarApplicationModel> memberModel = (await conn
                    .QueryAsync<CarApplicationModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }
        
        }
        /// <summary>
        /// 汽车保险登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<AIRModel>> AIRList(int regattaId, int userId)
        {
            var cmdText = "select * from air";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<AIRModel> memberModel = (await conn
                    .QueryAsync<AIRModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }

        }
        /// <summary>
        /// 车辆维修保养登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<VMRModel>> VMRList(int regattaId, int userId)
        {
            var cmdText = "select * from vmr";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<VMRModel> memberModel = (await conn
                    .QueryAsync<VMRModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }

        }
        /// <summary>
        /// 车辆年检登记表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<AIROVModel>> AIROVList(int regattaId, int userId)
        {
            var cmdText = "select * from airov";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<AIROVModel> memberModel = (await conn
                    .QueryAsync<AIROVModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }

        }
        /// <summary>
        /// 车辆加油登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<List<VRRModel>> VRRList(int regattaId, int userId) {
            var cmdText = "select * from vrr";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<VRRModel> memberModel = (await conn
                    .QueryAsync<VRRModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }
        }
        /// <summary>
        /// 车辆事故登记
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<VARModel>> VARList(int regattaId, int userId)
        {
            var cmdText = "select * from var";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<VARModel> memberModel = (await conn
                    .QueryAsync<VARModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }
        }

        // -------------------------------------《资产管理》-----------------------------------------
        /// <summary>
        /// 资产归还申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<AfarModel>>AfarList(int regattaId,int userId)
        {
            
                var cmdText = @"select * from afar";
                 
                //此处可以根据传入的regattaId访问不同的数据
                using(var conn =GetMySqlConnection(regattaId))
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
        /// 资产列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<AssetsListModel>> AssetsList(int regattaId, int userId)
        {
            var cmdText = "select * from assetslist";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<AssetsListModel> memberModel = (await conn
                    .QueryAsync<AssetsListModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }
        }

        /// <summary>
        /// 资产领用申请列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<CFAModel>> CFAList(int regattaId, int userId)
        {
            var cmdText = "select * from cfa";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<CFAModel> memberModel = (await conn
                    .QueryAsync<CFAModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }
        }
        /// <summary>
        /// APA资产采购
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<APAModel>> APAList(int regattaId, int userId)
        {
            var cmdText = "select * from apa";
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                List<APAModel> memberModel = (await conn
                    .QueryAsync<APAModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                    .ToList();
                return memberModel;
            }
        
        }


    }

}
