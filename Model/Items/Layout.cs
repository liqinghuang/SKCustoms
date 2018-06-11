﻿using Infrastruture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Layout:BaseEntity<long>
    {
        public string CarNumber { get; set; }

        public int SysUserId { get; set; }

        public string Description { get; set; }

        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 0：出 1：进 2：进出都触发
        /// </summary>
        public int TriggerType { get; set; }

        public Nullable<DateTime> ValideTime { get; set; }

        public int IsValid { get; set; }

        /// <summary>
        /// 布控程度 0：代表无限次数 1 代表一次中控，中控完该数据无效
        /// </summary>
        public int Degree { get; set; }
    }
}