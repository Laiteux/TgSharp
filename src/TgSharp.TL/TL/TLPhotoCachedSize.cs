using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TgSharp.TL;

namespace TgSharp.TL
{
    [TLObject(-374917894)]
    public class TLPhotoCachedSize : TLAbsPhotoSize
    {
        public override int Constructor
        {
            get
            {
                return -374917894;
            }
        }

        public string Type { get; set; }
        // manual edit: FileLocation->TLFileLocationToBeDeprecated
        public TLFileLocationToBeDeprecated Location { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public byte[] Bytes { get; set; }

        public void ComputeFlags()
        {
            // do nothing
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Type = StringUtil.Deserialize(br);
            // manual edit: FileLocation->TLFileLocationToBeDeprecated
            Location = (TLFileLocationToBeDeprecated)ObjectUtils.DeserializeObject(br);
            W = br.ReadInt32();
            H = br.ReadInt32();
            Bytes = BytesUtil.Deserialize(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Type, bw);
            ObjectUtils.SerializeObject(Location, bw);
            bw.Write(W);
            bw.Write(H);
            BytesUtil.Serialize(Bytes, bw);
        }
    }
}
