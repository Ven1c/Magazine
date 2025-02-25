using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Domain.Commands
{
    public class AddCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageSrc { get; set; }
    }
}
