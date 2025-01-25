using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGerDictionary
{
    public class DictionaryEntry
    {
        public string Ukrainian { get; set; }
        public string English { get; set; }
        public string German { get; set; }

        public DictionaryEntry(string ukrainian, string english, string german)
        {
            Ukrainian = ukrainian;
            English = english;
            German = german;
        }
    }
}
