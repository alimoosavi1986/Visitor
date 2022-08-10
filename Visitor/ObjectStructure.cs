using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ObjectStructure
    {
        private List<Element> elements = new List<Element>();
        public void Add(Element element)
        {
            elements.Add(element);
        }

        public void Remove(Element element)
        {
            elements.Remove(element);
        }

        public List<string> Accept(Visitor visitor)
        {
            List<string> results = new List<string>();
            foreach (var item in elements)
            {
                results.Add(item.Accept(visitor));
            }
            return results;
        }
    }
}
