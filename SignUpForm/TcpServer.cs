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
        public async void TcpOpen()
        {
            string localhost = "127.0.0.1";
            var ipEndPoint = new IPEndPoint(IPAddress.Parse(localhost), 8080);
            TcpListener listener = new TcpListener(ipEndPoint);

            byte[] buffer = new byte[0x100];

            listener.Start();

            Console.WriteLine("Open connection...\n");

            try
            {
                Console.WriteLine("Open connection...\n");

                using TcpClient client = await listener.AcceptTcpClientAsync();

                Console.WriteLine("Waiting connection...\n");

                await using NetworkStream stream = client.GetStream();
                string welcome = "[ACK] You are connected!!!";
                byte[] respond = Encoding.UTF8.GetBytes(welcome);
                await stream.WriteAsync(respond, 0, respond.Length);

                int received = await stream.ReadAsync(buffer, 0, buffer.Length);

                var message = Encoding.UTF8.GetString(buffer, 0, received);

                Console.WriteLine($"Message received from client: {message}");

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
