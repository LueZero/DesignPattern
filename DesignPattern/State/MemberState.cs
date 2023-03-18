using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    class MemberState : State
    {
        protected Order Oorder;

        const string License = "Member";

        const string OrderNumber = "20220530-002";

        public MemberState(Order order)
        {
            this.Oorder = order;
        }

        public override void Register()
        {
            return;
        }

        public override void Update()
        {
            Oorder.SetMemberState();
            Oorder.Update();
        }
    }
}
