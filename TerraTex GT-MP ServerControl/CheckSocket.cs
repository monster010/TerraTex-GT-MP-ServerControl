using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TerraTex_GT_MP_ServerControl
{
    class CheckSocket
    {
        private Form1 _form;
        
        public CheckSocket(Form1 form)
        {
            _form = form;
        }

        public void DoWork()
        {

            TcpListener serverSocket = new TcpListener(IPAddress.Any, 11000);
            TcpClient clientSocket = serverSocket.AcceptTcpClient();
            serverSocket.Start();

            while (true)
            {
                try
                {
                    NetworkStream networkStream = clientSocket.GetStream();
                    if (networkStream.DataAvailable)
                    {
                        networkStream.Read(new byte[10025], 0, 1);
                        string serverResponse = "{\"4499\": ";
                        serverResponse += _form.GetLiveStatus();
                        serverResponse += ", \"4599\": ";
                        serverResponse += _form.GetDevStatus();
                        serverResponse += "}";

                        Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                        networkStream.Write(sendBytes, 0, sendBytes.Length);
                        networkStream.Flush();
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

    }
}

