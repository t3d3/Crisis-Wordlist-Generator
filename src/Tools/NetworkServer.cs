using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Collections.Generic;

namespace crisis
{
    public class NetworkServer
    {
        private IPAddress lhost = null;
        private IPEndPoint iep = null;
        private List<ClientCommunication> client = new List<ClientCommunication>();
        private long nbClient;

        public NetworkServer()
        {
            Socket ss = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (IPAddress.TryParse(Property.Lhost, out lhost))
            {
                //Valid IP, with address containing the IP
                iep = new IPEndPoint(lhost, Property.Lport);                
            }

            ss.Bind(iep);
            ss.Listen(1);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n[*]");
            Console.ResetColor();
            Console.WriteLine(" Handler binding to LHOST {0}", Property.Lhost);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[*]");
            Console.ResetColor();
            Console.WriteLine(" Starting the server handler ...\n");

            while (true)
            {               

                Socket s = ss.Accept();
                ++nbClient;
                ClientCommunication cc = new ClientCommunication(s, nbClient);
                client.Add(cc);
                Thread th = new Thread(Comminication);
                th.Start(cc);
            }                       
        }
         


        class ClientCommunication
        {
            public Socket socket { get; set; }
            public long number { get; set; }
            
            public ClientCommunication(Socket s, long nbr)
            {
                this.socket = s;
                this.number = nbr;
            }
        }// End class

        
        public void Comminication(object o)
        {
            ClientCommunication cc = o as ClientCommunication;
            NetworkStream ns = new NetworkStream(cc.socket);
            TextReader tr = new StreamReader(ns);

            

            string ip = cc.socket.RemoteEndPoint.ToString();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[*]");
            Console.ResetColor();
            Console.WriteLine(" Sending stage to {0}",ip);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[*]");
            Console.ResetColor();
            Console.WriteLine(" Crisis session opened ({0}:{1} -> {2} ) at " + DateTime.Now + "\n", Property.Lhost, Property.Lport, ip);

            while (true)
            {
                string req = tr.ReadLine();
                broadcast(req);               
            }

        }// End Function


        internal void broadcast(string msg)
        {
            foreach (ClientCommunication cc in client)
            {
                //Socket s = cc.socket;
                //char[] typeOfProcedure = (char[])Parameter.TypesOfGeneration;
                //byte[] configClient = Encoding.Default.GetBytes(typeOfProcedure);
                //s.Send(configClient);
                
                
                //NetworkStream ns = new NetworkStream(s);
                //TextWriter tw = new StreamWriter(ns);
                //tw.WriteLine(msg);
                //tw.Flush();

                
            }
        }

    }// End class
} // End Namespace
