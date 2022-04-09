using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    internal class Status
    {
        public bool verified { get; set; }
        public string feedback { get; set; }
        public int sentCount { get; set; }
    }
}
