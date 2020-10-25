using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BySeal
    {
        /// <summary>
        /// 用章管理主键
        /// </summary>
        public int B_Id { get; set; }
        /// <summary>
        /// 主题
        /// </summary>
        public string B_Matter { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string B_EndTime { get; set; }
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
        public string B_ApplicationTime { get; set; }
        /// <summary>
        /// 印章名称外键
        /// </summary>
        public int SN_Id { get; set; }
        /// <summary>
        /// 事由及用途
        /// </summary>
        public string B_Purpose { get; set; }
        /// <summary>
        /// 用印文件名
        /// </summary>
        public string B_File { get; set; }
        /// <summary>
        /// 用印份数
        /// </summary>
        public int B_Used { get; set; }
        /// <summary>
        /// 预借时间
        /// </summary>
        public string B_AdvanceTime { get; set; }
        /// <summary>
        /// 归还时间
        /// </summary>
        public string B_ReturenTime { get; set; }
        /// <summary>
        /// 实际归还信息
        /// </summary>
        public string B_Information { get; set; }
        /// <summary>
        /// 申请人名称
        /// </summary>
        public string AName { get; set; }
        /// <summary>
        /// 所属部门名称
        /// </summary>
        public string DName { get; set; }
        /// <summary>
        /// 印章名称
        /// </summary>
        public string SN_Name { get; set; }
    }
}
