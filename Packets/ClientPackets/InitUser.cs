using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OssercClient.Packets.ClientPackets
{
    [DataContract]
    class InitUser
    {
        [DataMember(Order=1, IsRequired=true)]
        string username {get; set; }

        [DataMember(Order = 1, IsRequired = true)]
        string password {get; set; }

        [DataMember(Order = 1, IsRequired = false)]
        string token {get; set; }
    }
}
