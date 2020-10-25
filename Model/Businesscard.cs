using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 名片印制申请表
    /// </summary>
    public class Businesscard
    {
        /// <summary>
        /// 名片印制申请表主键
        /// </summary>
        public int BId { get; set; }
        /// <summary>
        /// 主题
        /// </summary>
        public string ThemeName { get; set; }
        /// <summary>
        /// 当前步骤
        /// </summary>
        public string Step { get; set; }
        /// <summary>
        /// 当前责任人
        /// </summary>
        public string Personliable { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 申请人外键
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 所属部门外键
        /// </summary>
        public int DId { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public string ApplicationTime { get; set; }
        /// <summary>
        /// 职务职称
        /// </summary>
        public string OfficialCapacity { get; set; }
        /// <summary>
        /// 办公地址
        /// </summary>
        public string OfficeAddress { get; set; }
        /// <summary>
        /// 办公电话
        /// </summary>
        public string Officephone { get; set; }
        /// <summary>
        /// 传真号
        /// </summary>
        public string FaxNumber { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
        ///电子邮件
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 网址
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// 申请数量
        /// </summary>
        public int NumberApplications { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

    }
}
