using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chain_Of_Responsibility
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("職責鏈模式測試");

            Refund sevenDays = new Refund("20220426001", 500, 7);
            Refund fifteenDays = new Refund("20220426001", 500, 20);
           
            Approver cd = new CustomerDepartment("客服部");
            Approver sd = new SalesDepartment("銷售部");

            // 設定責任鏈
            cd.NextApprover = sd;
            sd.NextApprover = null;

            cd.RefundRequest(sevenDays);
            cd.RefundRequest(fifteenDays);
        }
    }
}
