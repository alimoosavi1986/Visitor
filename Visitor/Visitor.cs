using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract string VisitConcreteElementA(ConcreteElementA element);
        public abstract string VisitConcreteElementB(ConcreteElementB element);

    }

    public class ConcreteVisitor1 : Visitor
    {
        public override string VisitConcreteElementA(ConcreteElementA element)
        {
            return $"Type:{element.GetType().Name}  Name:{element.Name}  Visitor:{this.GetType().Name}";
        }

        public override string VisitConcreteElementB(ConcreteElementB element)
        {
            return $"Type:{element.GetType().Name}  OrderId:{element.OrderId}  Visitor:{this.GetType().Name}";
        }
    }
}
