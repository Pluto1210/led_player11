using System.Net.Sockets;

namespace WindowsFormsApp1
{
    internal class ReadWriteObject
    {
        internal object netStream;
        private TcpClient client;

        public ReadWriteObject(TcpClient client)
        {
            this.client = client;
        }

        public object readBytes { get; internal set; }
    }
}