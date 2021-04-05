
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ChatRoomServer
{
    class Program
    {
        public static TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 55555);
        public static List<TcpClient> clients = new List<TcpClient>();
        public static List<string> names = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello server");
            listener.Start();
            receive();
            //foreach(var s in names)
            //{
            //    Console.WriteLine(s);
            //}

            
        }

        public static void receive()
        {
            while(true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client has connected");
                clients.Add(client);
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine("Server: What is your name?");
                sw.Flush();
                
                StreamReader sr = new StreamReader(client.GetStream());
                string name = sr.ReadLine();
                names.Add(name);
                Console.WriteLine("Server: " + name + " has joined the chat");
                broadcast("Server: " + name + " has joined the chat");

                Thread thread = new Thread(() => handle(client));
                thread.Start();

            }
        }

        public static void handle(TcpClient client)
        {
            StreamReader sr = new StreamReader(client.GetStream());

            while(true)
            {
                try
                {
                    string message = sr.ReadLine();
                    broadcast(message);
                    //Console.WriteLine(message);
                }
                catch(Exception e)
                {
                    int index = clients.IndexOf(client);
                    clients.Remove(client);
                    client.Close();

                    string name = names[index];
                    broadcast("Server: " + name + " has left the chat.");
                    names.Remove(name);
                    break;

                }
            }
        } 

        public static void broadcast(string message)
        {
            foreach(TcpClient client in clients)
            {
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine(message);
                sw.Flush();
                //Console.WriteLine(message);
            }

        }

        

    }
}


//while(true)
//            {
//                Console.WriteLine("Waiting for connection");
//                TcpClient client = listener.AcceptTcpClient();
//Console.WriteLine("Client accepted");
//                NetworkStream stream = client.GetStream();
//StreamReader sr = new StreamReader(client.GetStream());
//StreamWriter sw = new StreamWriter(client.GetStream());
//                while (true)
//                {



//                    try
//                    {
//                        byte[] buffer = new byte[1024];
//stream.Read(buffer, 0, buffer.Length);
//                        int recv = 0;
//                        foreach (byte b in buffer)
//                        {
//                            if (b != 0)
//                            {
//                                recv++;
//                            }
//                        }
//                        string request = Encoding.UTF8.GetString(buffer, 0, recv);
//Console.WriteLine("request recceived " + request);
//                        sw.WriteLine("Server to Client");
//                        sw.Flush();

//                    }
//                    catch (Exception e)
//                    {
//                        Console.WriteLine("Something went wrong!");
//                    }
//                }