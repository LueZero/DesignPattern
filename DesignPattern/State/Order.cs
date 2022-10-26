using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Order
    {
        protected State state;

        protected State guestState;

        protected State memberState;

        public Order()
        {
            guestState = new GuestState(this);
            memberState = new MemberState(this);
        }

        public void SetGuestState()
        {
            state = guestState;
        }

        public void SetMemberState()
        {
            state = memberState;
        }

        public void Update()
        {
            state.Update();
        }

        public void Register()
        {
            state.Register();
        }
    }
}
