using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MedicineInfo.TCP
{
    public class tcp
    {
        static public NetworkStream connect(string ip, int port)
        {
            TcpClient client = new TcpClient(ip, port);
            NetworkStream stream = client.GetStream();
            return stream;
        }
        async static public void send(NetworkStream stream, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length);
        }
        static public string recv(NetworkStream stream)
        {
            byte[] data = new byte[2048]; // 로그인 결과 수신
            int bytes = stream.Read(data, 0, data.Length);
            string responseData = Encoding.UTF8.GetString(data, 0, bytes);

            return responseData;
        }
        static async Task ReceiveMessages(NetworkStream stream)
        {
            byte[] data = new byte[4096];
            while (true)
            {
                int bytes = await stream.ReadAsync(data, 0, data.Length);
                string receivedMessage = Encoding.UTF8.GetString(data, 0, bytes);
                if (receivedMessage == "q")
                {
                    //Console.WriteLine("채팅 끝");
                    break;
                }
                //Console.WriteLine("Received: {0}", receivedMessage);
            }
        }

    }
}
