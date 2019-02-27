using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public class FitnessRecord
    {
        private List<ActivityEntry> _entries = new List<ActivityEntry>();

        public IReadOnlyList<ActivityEntry> Entries { get { return _entries; } }
    }
}
