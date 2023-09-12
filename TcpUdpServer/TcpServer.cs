using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpUdpServer;

public class TcpServer : Server
{
    // Initialize TCP listener
    public override void Start()
    {
        // Initialize TCP listener
        TcpListener tcpListener = new TcpListener(IPAddress.Any, Settings.TCP_PORT);
        tcpListener.Start();
        Console.WriteLine("TCP Server started. Waiting for messages...");

        while (true)
        {
            // Accept incoming client
            TcpClient client = tcpListener.AcceptTcpClient();
            Console.WriteLine("Client connected...");

            HandleClient(client);
        }
    }

    // Handle incoming client
    private void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string request = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        Console.WriteLine($"Received: {request}");

        // Process the request
        string response = ProcessMessage(request);

        // Send the response back to the client
        byte[] responseBytes = Encoding.ASCII.GetBytes(response);
        stream.Write(responseBytes, 0, responseBytes.Length);
        Console.WriteLine($"Sent: {response}");
    }

}

