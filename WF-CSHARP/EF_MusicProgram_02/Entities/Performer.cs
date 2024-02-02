using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MusicProgram.Entities
{
	public class Performer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country? Country { get; set; }
        public ICollection<Track>? Tracks { get; set; }
    }
}
