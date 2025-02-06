using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateOnly Hiring_Date { get; set; }
        public int Ins_id { get; set; }
    }
}
