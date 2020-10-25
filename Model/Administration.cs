using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 通用行政流程表
    /// </summary>
    public class Administration
    {
        /// <summary>
        /// 通用行政流程主键
        /// </summary>
        public int AId { get; set; }
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
        /// 发起人
        /// </summary>
        public string Sponsor { get; set; }
        /// <summary>
        /// 发起时间
        /// </summary>
        public string LaunchTime { get; set; }

    }
}
