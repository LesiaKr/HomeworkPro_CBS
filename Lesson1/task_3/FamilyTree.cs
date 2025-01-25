using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public class FamilyTree : ICollection<Relative>
    {
        private List<Relative> relatives = new List<Relative>
    {
        new Relative("Jany", 1992),
        new Relative("Fedir", 2000),
        new Relative("Marta", 1990),
        new Relative("Alex", 1948),
    };
        public int Count => relatives.Count;

        public bool IsReadOnly => false;

        public IEnumerator<Relative> GetEnumerator()
        {
            return relatives.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<Relative> GetByName(string name)
        {
            foreach (var relative in relatives)
            {
                if (relative.Name == name)
                {
                    yield return relative;
                    foreach (var child in GetDescendants(relative))
                    {
                        yield return child;
                    }
                }
            }
        }
        private IEnumerable<Relative> GetDescendants(Relative relative)
        {
            foreach (var child in relative.Children)
            {
                yield return child;
                foreach (var descendant in GetDescendants(child))
                {
                    yield return descendant;
                }
            }
        }

        public IEnumerable<Relative> GetByYear(int year)
        {
            foreach (var relative in relatives)
            {
                if (relative.YearBrth == year)
                {
                    yield return relative;
                }
            }
        }

        public void Add(Relative item)
        {
            relatives.Add(item);
        }

        public void Clear()
        {
            relatives.Clear();
        }

        public bool Contains(Relative item)
        {
            return relatives.Contains(item);
        }

        public void CopyTo(Relative[] array, int arrayIndex)
        {
            relatives.CopyTo(array, arrayIndex);
        }

        public bool Remove(Relative item)
        {
            return relatives.Remove(item);
        }
    }
}
