﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using Tracy.Frameworks.LogClient.Helper;
using Tracy.Frameworks.Common.Helpers;

namespace Tracy.Frameworks.LogClient.Entity
{
    /// <summary>
    /// 调试日志(debug log)
    /// </summary>
    public class DebugLog : BaseLog
    {
        private static readonly Process process = Process.GetCurrentProcess();

        public DebugLog()
        {
            Url = ConfigHelper.GetAppSetting("Log.OpenApi.Url") + "/api/debuglog/add";
            MachineName = System.Environment.MachineName;
            IPAddress = LogClientHelper.IP;
            ProcessID = process.Id;
            ProcessName = process.ProcessName;
            ThreadID = Thread.CurrentThread.ManagedThreadId;
            ThreadName = Thread.CurrentThread.Name;
            CreatedTime = DateTime.Now;
            AppDomainName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 应用程序域名称
        /// </summary>
        public string AppDomainName { get; set; }

    }
}
