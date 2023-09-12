using System.Net.Sockets;
using System.Net;
using System.Text;

namespace TcpUdpClient;

public class Client
{
    private const int TcpPort = 5000;
    private const int UdpPort = 5001;

    public void SendTcpMessage(string message)
    {
        // Connect to the server...
        TcpClient client = new TcpClient();
        client.Connect(IPAddress.Loopback, TcpPort);
        NetworkStream stream = client.GetStream();

        // Convert the message to bytes and send it
        byte[] data = Encoding.ASCII.GetBytes(message);
        stream.Write(data, 0, data.Length);

        // Receive the response from the server
        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Console.WriteLine($"Received: {response}");

    }

    public void SendUdpMessage(string message)
    {
        // Define the server endpoint and convert the message to bytes
        UdpClient client = new UdpClient();
        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Loopback, UdpPort);

        // Send the message
        byte[] data = Encoding.ASCII.GetBytes(message);
        client.Send(data, data.Length, serverEndPoint);

        // Receive the response from the server
        byte[] receivedData = client.Receive(ref serverEndPoint);
        string response = Encoding.UTF8.GetString(receivedData);
        Console.WriteLine($"Received: {response}");

    }
}

