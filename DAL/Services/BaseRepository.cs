using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAL.Services
{

    /// <summary>
    /// //用于读取Configuration，以及设置MySqlConnection
    /// </summary>

    public class BaseRepository : IDisposable
    {
        public static IConfigurationRoot Configuration { get; set; }

        private MySqlConnection conn;

        public MySqlConnection GetMySqlConnection(int regattaId = 0,bool open = true,bool convertZeroDatetime = false,bool allowZeroDatetime = false)
        
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json");

            Configuration = builder.Build();


            string cs = Configuration.GetConnectionString("DefaultConnection");
            cs = regattaId == 0 ? string.Format(cs, string.Empty) : string.Format(cs, "_" + regattaId.ToString());

            cs = cs.Replace("userName", "真正的账号").Replace("passWord", "真正的密码");
            var csb = new MySqlConnectionStringBuilder(cs)
            {
                AllowZeroDateTime = allowZeroDatetime,
                ConvertZeroDateTime = convertZeroDatetime
            };
            conn = new MySqlConnection(csb.ConnectionString);
            return conn;
        }
        public void Dispose()
        {
            if (conn != null && conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

    }

}

