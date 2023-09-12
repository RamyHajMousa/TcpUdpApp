namespace TcpUdpServer;

public abstract class Server
{
    public abstract void Start();

    public string ProcessMessage(string message)
    {
        string response = $"Server Acknowledgment: Your message has been successfully received as follows:\nMessage Content: '{message}'\nThank you for connecting.";
        return response;
    }

}

