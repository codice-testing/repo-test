using System.Net;

namespace Network
{
    internal class ServerSocket
    {
        internal int Recv(byte[] buffer)
        {
            System.IO.Read(buffer);
        }
    }

    internal class ClientSocket
    {
        internal int Send(byte[] buffer)
        {
            // modified on dst
            System.IO.Write(buffer);
            // modified on dst
        }

        internal void ConnectTo(string addr)
        {
            // connect to a client -- changed
            Net.ConnectTo(addr);
        }
    }

    internal class DNS
    {
        internal string GetHostByName(string addr)
        {
            // this method returns the host
            // when you give an addr
            return CalculateHostByName(addr);
        }

        internal void Listen()
        {
            // do the listen on a port
            // and whatever it is needed
            // to listen
            // modified on dst
        }
    }
}
