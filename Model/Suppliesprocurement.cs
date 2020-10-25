using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 用品采购表
    /// </summary>
    public class Suppliesprocurement
    {
        /// <summary>
        /// 用品采购主键
        /// </summary>
        public int SId { get; set; }
        /// <summary>
        /// 主题
        /// </summary>
        public string ThemeName { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        ///申请人外键
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
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Enclosure { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specifications { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public int InventoryQuantity { get; set; }
        /// <summary>
        /// 采购数量
        /// </summary>
        public int ProcurementQuantity { get; set; }
        /// <summary>
        /// 用途
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string AName { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string DName { get; set; }

    }

}

