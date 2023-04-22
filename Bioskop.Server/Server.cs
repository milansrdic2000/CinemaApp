using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Bioskop.Server
{
    public class Server
    {
        private static Server instance;
        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        private Socket serverSocket;
        public bool serverRunning = false;

        //delegati
        public Action<ClientHandler> addClientToDgv;
        public Action<ClientHandler> RemoveClientFromDgv;
        public Action refreshDgv;

        public List<ClientHandler> ListClients = new List<ClientHandler>();
        private Server()
        {

        }
        public void StartServer(string ip, int port)
        {
            try
            {

                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

                serverSocket.Bind(iPEndPoint);

                serverSocket.Listen(10);

                Console.WriteLine("Server is listening on port:" + port);

                serverRunning = true;

                //start accepting clients
                Thread t1 = new Thread(() => ClientListen());
                t1.IsBackground = true;
                t1.Start();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        public void Stop()
        {
            try
            {
                serverSocket.Close();
                serverRunning = false;

                foreach (ClientHandler clientHandler in ListClients)
                {
                    clientHandler.StopClient();
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void ClientListen()
        {
            try
            {
                while (serverRunning)
                {
                    Socket clientSocket = serverSocket.Accept();

                    ClientHandler clientHandler = new ClientHandler(clientSocket);
                    clientHandler.refreshClientsDgv = refreshDgv;
                    clientHandler.RemoveClientDgv = RemoveClientFromDgv;

                    //lista konektovanih klijenata
                    ListClients.Add(clientHandler);

                    addClientToDgv(clientHandler);


                    Thread t1 = new Thread(() => clientHandler.HandleRequest());
                    t1.IsBackground = true;
                    t1.Start();
                }
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        //public void ClientHandler(Socket clientSocket)
        //{
        //    try
        //    {
        //        while (serverRunning)
        //        {
        //            NetworkStream stream = new NetworkStream(clientSocket);
        //            BinaryFormatter formatter = new BinaryFormatter();

        //            Request req = (Request)formatter.Deserialize(stream);
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {

        //        throw ex;
        //    }
        //}



    }
}
