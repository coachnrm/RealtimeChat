using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
namespace DemoBlazorWebAppWasmSignalRChat.Client.ChatServices
{
    public class MyHubConnectionService
    {
        private readonly HubConnection _hubConnection;
        public bool IsConnected { get; set; }
        public MyHubConnectionService(NavigationManager navigationManager)
        {
            // Initialize the HubConnection (e.g., connect to your SignalR hub)
            _hubConnection = new HubConnectionBuilder()
           .WithUrl(navigationManager.ToAbsoluteUri("/chathub"))
           .Build();

            // Start the connection
            _hubConnection.StartAsync();
            GetConnectionState();
        }

        public HubConnection GetHubConnection() => _hubConnection;
        public bool GetConnectionState()
        {
            var hubConnection = GetHubConnection();
            IsConnected = hubConnection != null;
            return IsConnected;
        }


    }
}
