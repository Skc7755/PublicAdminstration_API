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
      
    }

}
