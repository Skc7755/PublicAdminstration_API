using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Stamp
    {
        /// <summary>
        /// 印章主键
        /// </summary>
        public int S_Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string S_Name { get; set; }
        /// <summary>
        /// 启用日期
        /// </summary>
        public string S_Commissioning { get; set; }
        /// <summary>
        /// 借用人
        /// </summary>
        public string S_Loaner { get; set; }
        /// <summary>
        /// 管理人
        /// </summary>
        public string S_Manager { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string S_Description { get; set; }
    }
}
