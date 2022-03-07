using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    /// <summary>
    /// 樹構件
    /// </summary>
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name)
        { 
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Delete(Component component)
        {
            _children.Remove(component);
        }

        public override void Show(int depth)
        {
            // 輸出樹形結構層次
            for (int i = 0; i < depth; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine(this.Name);

            // 向下遍歷
            foreach (Component compontent in _children)
            {
                compontent.Show(depth + 1);
            }
        }
    }
}
