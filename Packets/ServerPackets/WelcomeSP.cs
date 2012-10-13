using OssercClient.Packets.DataTypes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OssercClient.Packets.ServerPackets
{
    [DataContract]
    class WelcomeSP
    {
        [DataMember(Order=1, IsRequired=true)]
        public int version { get; set; }

        [DataMember(Order=2, IsRequired=true)]
        public ServerStatus serverStatus { get; set; }

        [DataMember(Order = 3, IsRequired = false)]
        public int msg { get; set; }
    }
}
