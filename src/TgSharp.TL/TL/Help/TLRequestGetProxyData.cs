using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TgSharp.TL;

namespace TgSharp.TL.Help
{
    [TLObject(1031231713)]
    public class TLRequestGetProxyData : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 1031231713;
            }
        }

        public Help.TLAbsProxyData Response { get; set; }

        public void ComputeFlags()
        {
            // do nothing
        }

        public override void DeserializeBody(BinaryReader br)
        {
            // do nothing
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            // do nothing else
        }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Help.TLAbsProxyData)ObjectUtils.DeserializeObject(br);
        }
    }
}
