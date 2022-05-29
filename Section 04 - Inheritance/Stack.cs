using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04Namespace
{
    internal class Stack
    {
        List<Object> stack = new List<Object>();
        
        public void Push(object obj)
        {
            if (obj == null) throw new InvalidOperationException("Can't push null onto the stack");
            
            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0) throw (new InvalidOperationException("The Stack is empty so can't pop"));

            object element = stack[stack.Count - 1];
                
            stack.RemoveAt(stack.Count - 1);

            return element;
        }

        public void Clear()
        {
            stack = new List<Object>();
        }

    }
}
