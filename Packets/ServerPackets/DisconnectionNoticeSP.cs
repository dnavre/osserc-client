using OssercClient.Packets.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OssercClient.Packets.ServerPackets
{
    [DataContract]
    class DisconnectionNoticeSP
    {
        [DataMember(Order = 1, IsRequired = true)]
        DisconnectionReason reason {get; set; }

        [DataMember(Order = 2, IsRequired = false)]
        string msg {get; set; }
    }
}
