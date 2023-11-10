using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class ExtraOption
    {
        public int ExtraOptionId { get; set; }
        public string Name { get; set; }

        public ExtraOption()
        {

        }

        public ExtraOption(int id, string name) {
            ExtraOptionId = id;
            Name = name;
        
        }


    }
}
