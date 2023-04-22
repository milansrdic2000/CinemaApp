using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bioskop.Common.CommunicationProtocol
{
    public class Reciever
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Reciever(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public T Recieve<T>()
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}
