using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoMongo
{
    public class VideoDocument
    {
        public VideoDocument(byte[] video)
        {
            _id = Guid.NewGuid().ToString();
            Video = video;
        }
        public string _id { get; set; }
        public byte[] Video { get; set; }
    }
}
