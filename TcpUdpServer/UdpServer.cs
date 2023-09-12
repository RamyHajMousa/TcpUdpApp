using System.Net.Sockets;
using System.Net;
using System.Text;

namespace TcpUdpServer;

public class UdpServer : Server
{
    // Initialize UDP Server...
    public override void Start()
    {
        // Initialize UDP listener (UdpClient)
        UdpClient udpListener = new UdpClient(Settings.UDP_PORT);
        Console.WriteLine("UDP Server started. Waiting for messages...");

        while (true)
        {
            // Listen for incoming data
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, Settings.UDP_PORT);
            byte[] buffer = udpListener.Receive(ref clientEndPoint);
            string message = Encoding.UTF8.GetString(buffer);
            Console.WriteLine($"Received: {message}");

            // Process the message and get the response
            string response = ProcessMessage(message);

            // Send the response back to the client
            byte[] responseBytes = Encoding.UTF8.GetBytes(response);
            udpListener.Send(responseBytes, responseBytes.Length, clientEndPoint);
            Console.WriteLine($"Sent: {response}");
        }
    }
}

