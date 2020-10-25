using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
   public interface PublicAdmin
    {
        public  Task<List<AfarModel>> AfarList(int regattaId, int userId);

        //登录
        public Task<List<LoginModel>> Login(string name,string pwd);
        //显示会议室列表
        public Task<List<ConferenceModel>> conferen(int regattaId, int userId);
        //显示会议室预定列表
        public Task<List<ManageModel>> manage(int regattaId, int userId);
        public  Task<ManageModel> fill(int id);
        public Task<ConferenceModel> fi( int id);
        public  Task<int> ManAdd(ManageModel m);
        public Task<int> ConAdd(ConferenceModel c);
    }
}
