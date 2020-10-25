using System;
using System.Threading.Tasks;
using Model;
using System.Collections.Generic;
using DAL.Services;

namespace BLL
{
    public class Bll
    {
        /// <summary>
        /// Afar列表
        /// </summary>
        /// <param name="regattaId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<AfarModel>> AfarList(int regattaId,int userId)
        {
            return await new Dal().AfarList(regattaId,userId);
        }
        public async Task<List<LoginModel>> Login(string name, string pwd)
        {
            return await new Dal().Login( name, pwd);
        }
        public async Task<List<ConferenceModel>> conferen(int regattaId, int userId)
        {
            return await new Dal().conferen(regattaId, userId);
        }
        public async Task<List<ManageModel>> manage(int regattaId, int userId)
        {
            return await new Dal().manage(regattaId, userId);
        }
        public async Task<ManageModel> fill(int regattaId, int userId,int id)
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
    }
}
