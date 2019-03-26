using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo
{
    public class Action
    {
        public int actionId { get; set; }
        public int fileId { get; set; }
        public int employeeId { get; set; }
        public int noteId { get; set; }
        public string actionDescription { get; set; }

        public FileNote FileNote { get; set; }
    }
}
