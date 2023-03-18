using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Order
    {
        protected State State;

        protected State GuestState;

        protected State MemberState;

        public Order()
        {
            GuestState = new GuestState(this);
            MemberState = new MemberState(this);
        }

        public void SetGuestState()
        {
            State = GuestState;
        }

        public void SetMemberState()
        {
            State = MemberState;
        }

        public void Update()
        {
            State.Update();
        }

        public void Register()
        {
            State.Register();
        }
    }
}
