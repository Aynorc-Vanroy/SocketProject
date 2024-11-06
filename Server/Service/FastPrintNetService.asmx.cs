using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services;
using Model;
using Server.Service;

namespace Server
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [ScriptService]
    public class FastPrintNetService : WebService
    {
        private static readonly IFastPrintNetService fastPrintNetService = new DefaultFastPrintNetService();

        [WebMethod(Description = "获取WebService服务器运行状态")]
        public string GetServiceRunStatus()
        {
            return "ok";
        }

        [WebMethod(Description = "获取在线客户端列表信息:GetOnlineClientsInfo")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<OnlineClient> GetOnlineClientsInfo()
        {
            return fastPrintNetService.GetOnlineClientsInfo();
        }

        [WebMethod(Description = "获取在线客户端数量:GetOnlineClientsTotalCount")]
        public string GetOnlineClientsTotalCount()
        {
            return fastPrintNetService.GetOnlineClientsTotalCount();
        }

        [WebMethod(Description = "发送消息")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public ResponseResult SendMessage(string userId, string data)
        {
            return fastPrintNetService.SendMessage(userId, data);
        }
    }
}
