using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bioskop.Common.CommunicationProtocol
{
    public class Sender
    {
        public Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Sender(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Send<T>(T request)
        {
            formatter.Serialize(stream, request);
        }

    }
}
