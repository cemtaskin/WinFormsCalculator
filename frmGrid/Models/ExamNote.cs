using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGrid.Models
{
    class ExamNote
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double MidTerm { get; set; }
        public double Final{ get; set; }
        public double Note { get { return MidTerm * 0.3 + Final * 0.7; } }
    }
}
