namespace Venom.Entity.Core.Component
{
    using System;

    /// <summary>
    /// 构造器实体
    /// </summary>
    public class Constructor
    {

        /// <summary>
        /// 构造器名
        /// </summary>
        public string ConstructorName { get; set; }

        /// <summary>
        /// 最大核心数
        /// </summary>
        public int MaxCoreNum { get; set; }

        /// <summary>
        /// 构建日期
        /// </summary>
        public DateTime BuildTime { get; set; }

    }
}
