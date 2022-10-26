using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    class MemberState : State
    {
        protected Order order;

        const string License = "Member";

        const string OrderNumber = "20220530-002";

        public MemberState(Order order)
        {
            this.order = order;
        }

        public override void Register()
        {
            return;
        }

        public override void Update()
        {
            order.SetMemberState();
            order.Update();
        }
    }
}
