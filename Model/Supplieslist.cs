using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 用品列表
    /// </summary>
    public class Supplieslist
    {
        /// <summary>
        /// 用品主键
        /// </summary>
        public int SId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string SName { get; set; }
        /// <summary>
        /// 类别外键
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specifications { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public int InventoryQuantity { get; set; }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 存放区域
        /// </summary>
        public string StorageArea { get; set; }
        /// <summary>
        /// 管理人
        /// </summary>
        public string Administrator { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string S_Describe { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Enclosure { get; set; }
        /// <summary>
        /// 用品类别
        /// </summary>
        public string CName { get; set; }
    }
}

