namespace TcpUdpClient;

public class ConsoleInterface
{
    // This method is to run the console interface...
    public void Run()
    {
        Client client = new Client();

        // Keep the program running until the user decides to quit...
        while (true)
        {
            // Display user options
            Console.WriteLine("Select an option:");
            Console.WriteLine("1: Send TCP message");
            Console.WriteLine("2: Send UDP message");
            Console.WriteLine("3: Quit");
            // Get user input
            string option = Console.ReadLine()!;

            // Process user input
            switch (option)
            {
                case "1":
                    Console.Write("Enter the TCP message: ");
                    string tcpMessage = Console.ReadLine()!;
                    client.SendTcpMessage(tcpMessage);
                    break;

                case "2":
                    Console.Write("Enter the UDP message: ");
                    string udpMessage = Console.ReadLine()!;
                    client.SendUdpMessage(udpMessage);
                    break;

                case "3":
                    Console.WriteLine("Terminating connection...");
                    return;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}

