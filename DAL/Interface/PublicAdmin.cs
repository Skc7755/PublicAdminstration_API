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
    }
}
