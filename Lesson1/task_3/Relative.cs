using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public class Relative
    {
        public string Name { get; set; }
        public int YearBrth { get; set; }
        public List<Relative> Children { get; set; }

        public Relative(string name, int yearBrth)
        {
            Name = name;
            YearBrth = yearBrth;
            Children = new List<Relative>();
        }
    }
}
