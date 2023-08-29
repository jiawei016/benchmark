using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBenchmark.src.Serialization.Models
{
    [ProtoContract]
    public class ProtoName
    {
        [ProtoMember(1)]
        public string first { get; set; }
        [ProtoMember(2)]
        public string last { get; set; }
    }
}
