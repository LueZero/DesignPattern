using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    class Order
    {
        private List<Status> _statuses = new List<Status>();

        public void Update(Status status)
        {
            _statuses.Add(status);
        }
    }
}
