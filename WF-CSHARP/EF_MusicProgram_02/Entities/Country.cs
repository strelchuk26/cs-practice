using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MusicProgram.Entities
{
	public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Performer> Performers { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
