using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLTI
{
    public class AllVirtualMachines
    {
        public List<VirtualMachine> servers { get; set; }
    }

    public class VirtualMachine
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        //public string Status { get; set; }
        
    }
}
