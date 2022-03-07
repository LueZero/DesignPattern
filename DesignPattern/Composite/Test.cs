using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("組合模式測試");

            // 建立根節點
            Composite root = new Composite("root");

            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            // 建立第二層節點
            Composite branch = new Composite("branch");
            branch.Add(new Leaf("branch BX"));
            branch.Add(new Leaf("branch BY"));
            root.Add(branch);

            // 建立第三層節點
            Composite branch2 = new Composite("branch2");
            branch2.Add(new Leaf("branch2 BBX"));
            branch2.Add(new Leaf("branch2 BBY"));
            root.Add(branch2);

            // 葉子節點操作
            Composite branch3 = new Composite("branch3");
            Leaf leaf = new Leaf("Leaf L");
            Leaf leaf1 = new Leaf("Leaf L1");
            leaf.Add(leaf1);
            leaf.Delete(leaf1);
            branch3.Add(leaf);
            branch3.Add(leaf1);
            branch3.Delete(leaf);
            root.Add(branch3);

            // 顯示
            root.Show(1);

            Console.Read();
        }
    }
}
