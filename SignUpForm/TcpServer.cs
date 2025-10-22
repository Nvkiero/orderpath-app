using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCP
{
    class TcpServer
    {
        public void TcpOpen()
        {
            string localhost = "127.0.0.1";
            var ipEndPoint = new IPEndPoint(IPAddress.Parse(localhost), 8080);
            TcpListener listener = new TcpListener(ipEndPoint);
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[0x100];
                    byte[] respond = new byte[0x100];

                    listener.Start();

                    Console.WriteLine("Waiting connection...\n");

                    using (TcpClient client = listener.AcceptTcpClient())
                    {
                        NetworkStream stream = client.GetStream();

                        int received = stream.Read(buffer, 0, buffer.Length);

                        var message = Encoding.UTF8.GetString(buffer, 0, received);

                        Console.WriteLine($"Message received from client: {message}");
                    }
                }
            } catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");

            } finally
            {
                listener.Stop();
                Console.WriteLine("Server stop!");
            }
        }
    }
}
