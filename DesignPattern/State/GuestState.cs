using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    class GuestState : State
    {
        protected Order order;

        const string License = "Guest";

        const string OrderNumber = "20220530-001";

        public GuestState(Order order)
        {
            this.order = order;
        }

        public override void Register()
        {
            return;
        }

        public override void Update()
        {
            throw new Exception("Sorry, you have not permission.");
        }
    }
}
