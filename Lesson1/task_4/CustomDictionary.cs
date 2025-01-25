using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGerDictionary
{
    public class CustomDictionary : IEnumerable<DictionaryEntry>
    {
        private List<DictionaryEntry> entries = new List<DictionaryEntry>();

        public void Add(string ukrainian, string english, string german)
        {
            entries.Add(new DictionaryEntry(ukrainian, english, german));
        }

        public string GetEnglish(string ukrainian)
        {
            var entry = entries.Find(e => e.Ukrainian == ukrainian);
            return entry?.English;
        }

        public string GetGerman(string ukrainian)
        {
            var entry = entries.Find(e => e.Ukrainian == ukrainian);
            return entry?.German;
        }

        public IEnumerator<DictionaryEntry> GetEnumerator()
        {
            return entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
