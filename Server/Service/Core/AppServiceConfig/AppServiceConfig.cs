﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Core
{
    public class AppServiceConfig
    {
        /// <summary>
        /// redis连接字符串
        /// </summary>
        public string RedisConnectionString { get; set; }
    }
}