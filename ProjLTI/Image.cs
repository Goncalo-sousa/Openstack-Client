using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLTI
{
    public class AllImages
    {
        public List<Image> images { get; set; }
    }

    public class Image
    {
        /*public string Id { get; set; }*/

        public string Name { get; set; }
        public string Status { get; set; }
        public string DiskFormat { get; set; }
        public string Visibility { get; set; }
        public string Size { get; set; }
        public string Id { get; set; }
        public bool Protected { get; set; }
        public string File { get; set; }

        //public string Status { get; set; }

    }
}
