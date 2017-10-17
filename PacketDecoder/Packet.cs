using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketDecoder
{
    class Packet
    {
        public Int32 Time { get; set; }
        public Int32 Num { get; set; }
        public String Direction { get; set; }
        public String Url { get; set; }
        public String Type { get; set; }
        public String EncryptedJson { get; set; }
        public String DecryptedJson { get; set; }
        public String GameObject { get; set; }
    }
}
