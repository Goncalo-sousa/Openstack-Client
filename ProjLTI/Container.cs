using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLTI
{
    public class AllContainers
    {
        public List<Container> containers { get; set; }
    }

    public class Container
    {
        /*public string Id { get; set; }*/

        public string uuid { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string host { get; set; }
        public string cpu { get; set; }
        public string disk { get; set; }
        public string user_id { get; set; }
        public string cpu_policy { get; set; }
        

        

    }
}
