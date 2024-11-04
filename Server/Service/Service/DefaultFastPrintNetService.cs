using System.Collections.Generic;
using Model;
using Utility;
using System;
using System.Linq;
using SuperSocket.SocketBase;
using System.Text;
using System.Xml;
using Server;
using Server.Core.Strategy;


// ReSharper disable once CheckNamespace
namespace Server.Service
{
    public class DefaultFastPrintNetService : IFastPrintNetService
    {
        //给指定用户发送消息
        public ResponseResult SendMessage(string userId, string data)
        {
            return FastPrintStrategy.Instance.SendMessage(userId, data);
        }

        //获取在线客户端信息
        public List<OnlineClient> GetOnlineClientsInfo()
        {
            List<OnlineClient> onlineClients=new List<OnlineClient>();
            var dicOnlineClients = FastPrintStrategy.Instance.OnlineAppClients;
            
            if (dicOnlineClients != null && dicOnlineClients.Count > 0)
            {
                onlineClients = FastPrintStrategy.Instance.OnlineAppClients.Select(s => new OnlineClient
                {
                    UserID = s.Key,
                    UserAddress = s.Value.RemoteEndPoint.ToString(),
                }).OrderBy(s => s.UserID).ToList();
                return onlineClients;
            }
            return onlineClients;
        }

        //获取在线客户端总数
        public string GetOnlineClientsTotalCount()
        {
            if (
                FastPrintStrategy.Instance.OnlineAppClients != null
                && 
                FastPrintStrategy.Instance.OnlineAppClients.Count > 0
                )
                return FastPrintStrategy.Instance.OnlineAppClients.Count.ToString();
            return string.Empty;
        }
    }
}