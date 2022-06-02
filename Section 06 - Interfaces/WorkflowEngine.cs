using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section06Namespace
{
    internal class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach(IActivity activity in workflow)
            {
                if (activity == null) continue;

                activity.Execute();
            }
        }


    }
}
