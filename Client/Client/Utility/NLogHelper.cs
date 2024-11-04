﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace Client.Utility
{
    public class NLogHelper
    {
        /// <summary>
        /// 获取NLog实例。
        /// </summary>
        public readonly static Logger Instance = LogManager.GetCurrentClassLogger();
    }
}
