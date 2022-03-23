using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    /// <summary>
    /// 葉子構件
    /// </summary>
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        { 
        }

        // 如果是葉子節點，則不允許進行新增節點，因為葉子節點下再沒有節點了
        public override void Add(Component component)
        {
            Console.WriteLine("葉子節點不能新增其他內容");
        }

        // 如果是葉子節點，則不允許進行刪除節點，因為葉子節點下再沒有節點了
        public override void Delete(Component component)
        {
            Console.WriteLine("葉子節點不能刪除內容");
        }

        public override void Show(int depth)
        {
            // 輸出葉子節點
            for (int i = 0; i < depth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(this.Name);
        }
    }
}
