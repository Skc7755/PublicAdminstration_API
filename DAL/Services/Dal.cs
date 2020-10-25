using System;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;
using Model;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using DAL.Interface;
using System.Net.Http;

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

            var cmdText = $"select * from afar";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var memberModel = (await conn
                 .QueryAsync<AfarModel>(cmdText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return memberModel;
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
            var bysText = @"select * from byseal b join applicant a on a.AId=b.A_Id join department d on d.DId=b.D_Id join sealname s on s.SN_Id=b.SN_Id GROUP BY b.B_Id DESC";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var bysModel = (await conn
                 .QueryAsync<BySeal>(bysText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return bysModel;
            }
        }

        /// <summary>
        /// 获取印章列表信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Stamp>> GetStamps(int regattaId, int userId)
        {
            var staText = @"select * from Stamp s GROUP BY s.S_Id DESC";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var staModel = (await conn
                 .QueryAsync<Stamp>(staText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return staModel;
            }
        }

        /// <summary>
        /// 获取证照列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Certification>> GetCertifications(int regattaId, int userId)
        {
            var cerText = @"select * from Certification c GROUP BY c.C_Id DESC";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var cerModel = (await conn
                 .QueryAsync<Certification>(cerText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return cerModel;
            }
        }

        /// <summary>
        /// 获取证照借用信息
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<License>> GetLicenses(int regattaId, int userId)
        {
            var licText = @"select * from license l JOIN applicant a on a.AId=l.A_Id join department d on d.DId=l.D_Id JOIN licensename li on li.LN_Id=l.LN_Id GROUP BY l.L_Id DESC";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var licModel = (await conn
                 .QueryAsync<License>(licText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return licModel;
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
            var dptText = @"select * from Department";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var dptModel = (await conn
                 .QueryAsync<Department>(dptText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return dptModel;
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
            var lnText = @"select * from LicenseName";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var lnModel = (await conn
                 .QueryAsync<LicenseName>(lnText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return lnModel;
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
            var snText = @"select * from SealName";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var snModel = (await conn
                 .QueryAsync<SealName>(snText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return snModel;
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
            var appText = @"select * from Applicant";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection(regattaId))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var appModel = (await conn
                 .QueryAsync<Applicant>(appText, new { userId = userId }, commandType: System.Data.CommandType.Text))
                 .ToList();
                return appModel;
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
            var licpText = $"select * from license l JOIN applicant a on a.AId=l.A_Id join department d on d.DId=l.D_Id JOIN licensename li on li.LN_Id=l.LN_Id WHERE l.L_Id='{licId}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var licpModel = await conn
                 .QueryFirstOrDefaultAsync<License>(licpText, commandType: System.Data.CommandType.Text);
                return licpModel;
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
            var stpText = $"select * from stamp s WHERE s.S_Id='{stId}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var stpModel = await conn
                 .QueryFirstOrDefaultAsync<Stamp>(stpText, commandType: System.Data.CommandType.Text);
                return stpModel;
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
            var bypText = $"select * from byseal b join applicant a on a.AId=b.A_Id join department d on d.DId=b.D_Id join sealname s on s.SN_Id=b.SN_Id WHERE b.B_Id='{byId}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var bypModel = await conn
                 .QuerySingleOrDefaultAsync<BySeal>(bypText, commandType: System.Data.CommandType.Text);
                return bypModel;
            }
        }

        /// <summary>
        /// 证照列表详情
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <param name="cerId"></param>
        /// <returns></returns>
        public async Task<Certification> CerParticulars(int cerId)
        {
            var cerpText = $"select * from certification c WHERE c.C_Id='{cerId}'";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var cerpModel = await conn
                 .QueryFirstOrDefaultAsync<Certification>(cerpText, commandType: System.Data.CommandType.Text);
                return cerpModel;
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
            var adcerText = $"insert into certification (C_Name,C_Number,C_Authority,C_Date,C_Review,C_Validity,C_Annual,C_Loaner,C_Manager,C_Description) VALUES('{cer.C_Name}', '{cer.C_Number}', '{cer.C_Authority}', '{cer.C_Date}',{cer.C_Review},{cer.C_Validity}, '{cer.C_Annual}', '{cer.C_Loaner}', '{cer.C_Manager}', '{cer.C_Description}')";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var adcerModel = await conn
                 .ExecuteAsync(adcerText, commandType: System.Data.CommandType.Text);
                return adcerModel;
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
            var adstaText = $"insert into stamp (S_Name,S_Commissioning,S_Loaner,S_Manager,S_Description) VALUES('{sta.S_Name}','{sta.S_Commissioning}','{sta.S_Loaner}','{sta.S_Manager}','{sta.S_Description}')";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var adstaModel = await conn
                 .ExecuteAsync(adstaText, commandType: System.Data.CommandType.Text);
                return adstaModel;
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
            var adlicText = $"insert into license (L_Matter,L_EndTime,A_Id,D_Id,L_ApplicationTime,LN_Id,L_Purpose,L_AdvanceTime,L_ReturenTime,L_Information) VALUES('{lic.L_Matter}', '{lic.L_EndTime}', '{lic.A_Id}', '{lic.D_Id}', '{lic.L_ApplicationTime}', '{lic.LN_Id}', '{lic.L_Purpose}', '{lic.L_AdvanceTime}', '{lic.L_ReturenTime}', '{lic.L_Information}')";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var adlicModel = await conn
                 .ExecuteAsync(adlicText, commandType: System.Data.CommandType.Text);
                return adlicModel;
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
            var adbysText = $"insert into byseal (B_Matter,B_EndTime,A_Id,D_Id,B_ApplicationTime,SN_Id,B_Purpose,B_File,B_Used,B_AdvanceTime,B_ReturenTime,B_Information) VALUES('{bys.B_Matter}', '{bys.B_EndTime}',{bys.A_Id},{bys.D_Id}, '{bys.B_ApplicationTime}',{bys.SN_Id}, '{bys.B_Purpose}', '{bys.B_File}', '{bys.B_Used}', '{bys.B_AdvanceTime}', '{bys.B_ReturenTime}', '{bys.B_Information}')";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var adbysModel = await conn
                 .ExecuteAsync(adbysText, commandType: System.Data.CommandType.Text);
                return adbysModel;
            }
        }

        /// <summary>
        /// 删除证照列表信息
        /// </summary>
        /// <param name="cerId"></param>
        /// <returns></returns>
        public async Task<int> DelCertification(int dcerId)
        {
            var adbysText = $"DELETE FROM certification WHERE C_Id={dcerId}";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var adbysModel = await conn
                 .ExecuteAsync(adbysText, commandType: System.Data.CommandType.Text);
                return adbysModel;
            }
        }

        /// <summary>
        /// 删除证照借用信息
        /// </summary>
        /// <param name="dlicId"></param>
        /// <returns></returns>
        public async Task<int> DelCerLicense(int dlicId)
        {
            var adbysText = $"DELETE FROM license WHERE L_Id={dlicId}";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var adbysModel = await conn
                 .ExecuteAsync(adbysText, commandType: System.Data.CommandType.Text);
                return adbysModel;
            }
        }

        /// <summary>
        /// 删除印章列表信息
        /// </summary>
        /// <param name="dstId"></param>
        /// <returns></returns>
        public async Task<int> DelStamp(int dstId)
        {
            var adbysText = $"DELETE FROM stamp WHERE S_Id={dstId}";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var adbysModel = await conn
                 .ExecuteAsync(adbysText, commandType: System.Data.CommandType.Text);
                return adbysModel;
            }
        }

        /// <summary>
        /// 删除印章管理信息
        /// </summary>
        /// <param name="dbyId"></param>
        /// <returns></returns>
        public async Task<int> DelBySeal(int dbyId)
        {
            var adbysText = $"DELETE FROM bySeal WHERE b_Id={dbyId}";

            //此处可以根据传入的regattaId访问不同的数据
            using (var conn = GetMySqlConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var adbysModel = await conn
                 .ExecuteAsync(adbysText, commandType: System.Data.CommandType.Text);
                return adbysModel;
            }
        }
    }
}
