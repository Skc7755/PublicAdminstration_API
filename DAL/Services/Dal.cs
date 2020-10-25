using System;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;
using Model;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using DAL.Interface;
using System.Configuration;

namespace DAL.Services
{
    public class Dal:BaseRepository,PublicAdmin
    {
        /// <summary>
        /// Afar列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<AfarModel>>AfarList(int regattaId,int userId)
        {
            
                var cmdText = @"select * from afar";
                 
                //此处可以根据传入的regattaId访问不同的数据
                using (var conn =GetMySqlConnection(regattaId))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                       await conn.OpenAsync();
                    }

                     var memberModel =conn
                      .Query<AfarModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text)
                      .ToList();
                    return memberModel;
                }

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public async Task<List<LoginModel>> Login(string name,string pwd)
        {

             var deng = $"select count(*) from login where UserName='{name}' and UserPassWord='{pwd}'" ;

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
        /// 显示会议室列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 显示会议室预定列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 会议室预定列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 会议室列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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

                var fantian =await conn.QueryFirstOrDefaultAsync<ConferenceModel>(fan, commandType: System.Data.CommandType.Text);
                return fantian;
            }

        }
        /// <summary>
        /// 添加会议室预定
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        
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
        /// 添加会议室
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
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
