using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section06Namespace
{
    internal class Workflow : IEnumerable<IActivity>
    {
        private readonly IList<IActivity> _workflows = new List<IActivity>();

        public void AddActivity(IActivity activity)
        {
            if (activity == null) throw new ArgumentNullException();

            _workflows.Add(activity);
        }

        public IEnumerator GetEnumerator()
        {
            return _workflows.GetEnumerator();
        }

        IEnumerator<IActivity> IEnumerable<IActivity>.GetEnumerator()
        {
            return _workflows.GetEnumerator();
        }
    }
}
