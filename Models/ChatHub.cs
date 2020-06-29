using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using basKet.Models;

namespace basKet.Models.Hubs
{
    public class ChatHub : Hub
    {
        static List<BaseUser> BaseUser = new List<BaseUser>();

        // Отправка сообщений
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }

        // Подключение нового пользователя
        public void Connect(string userName)
        {
            string id = Context.ConnectionId;


            if (!BaseUser.Any( x => x.ConnectionId == id))
            {
                BaseUser.Add(new BaseUser { ConnectionId = id, Username = userName });

                // Посылаем сообщение текущему пользователю
                Clients.Caller.onConnected(id, userName, BaseUser);

                // Посылаем сообщение всем пользователям, кроме текущего
                Clients.AllExcept(id).onNewUserConnected(id, userName);
            }
        }

        // Отключение пользователя
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            var item = BaseUser.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            if (item != null)
            {
                BaseUser.Remove(item);
                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.Username);
            }

            return base.OnDisconnected(stopCalled);
        }
    }
}