using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 行政接待申请表
    /// </summary>
    public class Reception
    {
        /// <summary>
        /// 行政接待申请表主键
        /// </summary>
        public int RId { get; set; }
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
        /// 接待日期
        /// </summary>
        public string ReceptionDate { get; set; }
        /// <summary>
        /// 接待对象
        /// </summary>
        public string ReceptionObject { get; set; }
        /// <summary>
        /// 接待事由
        /// </summary>
        public string SubjectMatter { get; set; }
        /// <summary>
        /// 接待类型
        /// </summary>
        public string ReceptionType { get; set; }
        /// <summary>
        /// 预算金额
        /// </summary>
        public string BudgetAmount { get; set; }
        /// <summary>
        /// 接待安排
        /// </summary>
        public string Arrange { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Enclosure { get; set; }

    }
}
