using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using ProtoBuf;

namespace OssercClient.Packets.DataTypes
{
    [DataContract]
    [ProtoContract]
    enum ServerStatus
    {
        [EnumMember]
        [ProtoEnum]
        ONLINE = 0,

        [EnumMember]
        [ProtoEnum]
        OFFLINE = 1,

        [EnumMember]
        [ProtoEnum]
        AUTH_SERVER_OFFLINE = 2,

        [EnumMember]
        [ProtoEnum]
        MAINTENANCE = 3,

        [EnumMember]
        [ProtoEnum]
        MAP_SERVER_OFFLINE =4
    }
}
