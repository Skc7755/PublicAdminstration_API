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
    }
}
