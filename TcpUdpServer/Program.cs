using TcpUdpServer;

// Start TCP Server in its own thread
Thread tcpThread = new(new ThreadStart(() =>
{
    TcpServer tcpServer = new();
    tcpServer.Start();
}));

tcpThread.Start();

// Start UDP Server in its own thread
Thread udpThread = new Thread(new ThreadStart(() =>
{
    UdpServer udpServer = new UdpServer();
    udpServer.Start();
}));

udpThread.Start();