using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace SignUpForm.TCPClient
{
    public class TCPClientHelper
    {
        private TcpClient client;
        private NetworkStream stream;

        public bool Connect(string ip, int port)
        {
            try
            {
                client = new TcpClient(ip, port);
                stream = client.GetStream();
                Console.WriteLine("Đã kết nối tới server.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Lỗi khi kết nối: {ex.Message}");
                return false;
            }
        }

        public void SendMessage(string message)
        {
            if (client == null || !client.Connected)
            {
                Console.WriteLine(" Chưa kết nối server.");
                return;
            }

            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
            Console.WriteLine($" Gửi: {message}");
        }
        public string ReceiveMessage()
        {
            if (client == null || !client.Connected)
                return " Chưa kết nối server.";

            byte[] buffer = new byte[1024];
            int bytes = stream.Read(buffer, 0, buffer.Length);
            string response = Encoding.UTF8.GetString(buffer, 0, bytes);
            Console.WriteLine($" Nhận: {response}");
            return response;
        }

        public void Disconnect()
        {
            if (client != null)
            {
                stream.Close();
                client.Close();
                Console.WriteLine(" Đã ngắt kết nối.");
            }
        }
    }
}