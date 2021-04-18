using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLTI
{
    public class AllProject
    {
        public List<Project> projects  { get; set; }
    }
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Self { get; set; }
    }
}
