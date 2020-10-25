using System;

namespace Model
{
    public class Certification
    {
        /// <summary>
        /// 证照主键
        /// </summary>
        public int C_Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string C_Name { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public string C_Number { get; set; }
        /// <summary>
        /// 签发机关
        /// </summary>
        public string C_Authority { get; set; }
        /// <summary>
        /// 签发日期
        /// </summary>
        public string C_Date { get; set; }
        /// <summary>
        /// 是否年审
        /// </summary>
        public bool C_Review { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public int C_Validity { get; set; }
        /// <summary>
        /// 下次年审日期
        /// </summary>
        public string C_Annual { get; set; }
        /// <summary>
        /// 借用人
        /// </summary>
        public string C_Loaner { get; set; }
        /// <summary>
        /// 管理人
        /// </summary>
        public string C_Manager { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string C_Description { get; set; }
    }
}
