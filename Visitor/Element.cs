using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Element
    {
        public abstract string Accept(Visitor visitor);
    }

    public class ConcreteElementA : Element
    {
        public string Name { get; private set; }
        public ConcreteElementA(string name)
        {
            this.Name = name;
        }

        public override string Accept(Visitor visitor)
        {
            return visitor.VisitConcreteElementA(this);
        }
    }


    public class ConcreteElementB : Element
    {
        public string OrderId { get; private set; }

        public ConcreteElementB(string orderid)
        {
            this.OrderId = orderid;
        }
        public override string Accept(Visitor visitor)
        {
            return visitor.VisitConcreteElementB(this);
        }
    }
}
