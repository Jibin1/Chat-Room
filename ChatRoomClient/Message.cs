using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomClient
{
    public class Message
    {
        public string user;
        public string message;

        public Message(string user, string message)
        {
            this.user = user;
            this.message = message;
        }
    }
}
