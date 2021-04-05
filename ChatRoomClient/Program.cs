using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ChatRoomClient
{
    class Program
    {
        
        
        static void Main(string[] args)
        {

            Application.Run(new ChatWindow());
            
        }

        

    }
}
