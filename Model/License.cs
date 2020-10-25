using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class License
    {
        /// <summary>
        /// 证照借用主键
        /// </summary>
        public int L_Id { get; set; }
        /// <summary>
        /// 主题
        /// </summary>
        public string L_Matter { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string L_EndTime { get; set; }
        /// <summary>
        /// 申请人外键
        /// </summary>
        public int A_Id { get; set; }
        /// <summary>
        /// 所属部门外键
        /// </summary>
        public int D_Id { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public string L_ApplicationTime { get; set; }
        /// <summary>
        /// 证照名称外键
        /// </summary>
        public int LN_Id { get; set; }
        /// <summary>
        /// 事由及用途
        /// </summary>
        public string L_Purpose { get; set; }
        /// <summary>
        /// 预借时间
        /// </summary>
        public string L_AdvanceTime { get; set; }
        /// <summary>
        /// 归还时间
        /// </summary>
        public string L_ReturenTime { get; set; }
        /// <summary>
        /// 实际归还信息
        /// </summary>
        public string L_Information { get; set; }
        /// <summary>
        /// 申请人名称
        /// </summary>
        public string AName { get; set; }
        /// <summary>
        /// 所属部门名称
        /// </summary>
        public string DName { get; set; }
        /// <summary>
        /// 证照名称
        /// </summary>
        public string LN_Name { get; set; }
    }
}
