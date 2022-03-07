using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    /// <summary>
    /// 抽象構件
    /// </summary>
    public abstract class Component
    {
        public string Name { get; set; }

        public Component(string name)
        {
            this.Name = name;
        }

        // 新增一個葉子構件或樹枝構件
        public abstract void Add(Component component);

        // 刪除一個葉子構件或樹枝構件
        public abstract void Delete(Component component);

        // 獲取分支下的所有葉子構件和樹枝構件
        public abstract void Show(int depth);
    }
}
