using NLog;
using Logger = NLog.Logger;

namespace Utility
{
    public class NLogHelper
    {
        /// <summary>
        /// 获取NLog实例。
        /// </summary>
        public readonly static Logger Instance = LogManager.GetCurrentClassLogger();
    }
}
