using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OssercClient.Packets.DataTypes
{
    [DataContract]
    [ProtoContract]
    enum DisconnectionReason
    {
        [EnumMember]
        [ProtoEnum]
        SERVER_SHUTDOWN = 0,

        [EnumMember]
        [ProtoEnum]
        WRONG_CREDENTIALS = 1,

        [EnumMember]
        [ProtoEnum]
        TIMEOUT = 2,

        [EnumMember]
        [ProtoEnum]
        OTHER=3,

        [EnumMember]
        [ProtoEnum]
        CONNECTION_ERROR=4
    }
}
