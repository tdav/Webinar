using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webinar.Hubs
{
    public class WebrtcSignalingHub : Hub
    {

        public override Task OnConnectedAsync()
        {
            string name = Context.User.Identity.Name;

            //name = GetClientName();
            //var browser = GetBrowser();

            //if (!ConnectedUsers.Any(c => c.Name == name || c.ConnectionId == Context.ConnectionId))
            //{
            //    ConnectedUsers.Add(new User() { Name = name, ConnectionId = Context.ConnectionId, Browser = browser, BroMedia = Media.None });
            //};

            //ShowUsersOnLine();

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            //string name = Context.User.Identity.Name;
            //name = GetClientName();

            //var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);

            //ConnectedUsers.Remove(item);

            //ShowUsersOnLine();

            return base.OnDisconnectedAsync(exception);
        }


        public Task SendUser(string mes, string userId)
        {
            return Clients.User(userId).SendAsync("SendCaller", mes);
        }

        public Task SendCaller(string mes)
        {
            return Clients.Caller.SendAsync("SendCaller", mes);
        }

        public Task SendAll(string mes)
        {
            return Clients.All.SendAsync("SendAll", mes);
        }

        public Task SendOther(string mes)
        {
            return Clients.Others.SendAsync("SendOther", mes);
        }

        public Task SendGroup(string mes)
        {
            string name = Context.User.Identity.Name;
            var groups = "";// GetGroup(name);
            return Clients.OthersInGroup(groups).SendAsync("SendGroup", mes);
        }


        public void Join()
        {

        }
        
        public void Leave()
        {

        }
        
        public void TestMessage()
        {

        }
        
        public void VoiceMessage()
        {

        }
        
        public void SystemMessage()
        {

        }


    }
}
