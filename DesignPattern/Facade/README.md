# 外觀模式 Facade Pattern

為子系統中的一組介面提供一個統一的高層介面，使得子系統更容易使用。

將多個對象組合起來，它不需要生產者，也不需要得到不同的結果。有點像虛函數和普通函數的區別。

## 優點：

* 解除了高階與子系統間的耦合關係。
* 可以透過接口類，來操作子系統中複雜的功能。

## 缺點：

* 接口類可能會因為耦合太多子系統，而職責過重。

## 範例


> 身為蘋果公司情境。

```C#
class Apple
{
    public Apple Set()
    {
        return this;
    }

    public Apple Make()
    {
        return this;
    }

    public string Check()
    {
        return "OK";
    }

}
```

> 只是老闆發現，作業員都必須要知道生產流程。對作業員不是那麼友善，希望能改善。


定義Apple生產介面

```C#
public interface ProductionInterface
{
    public ProductionInterface Set();

    public ProductionInterface Make();

    public string Check();
}

class Apple : ProductionInterface
{
    public ProductionInterface Set()
    {
        return this;
    }

    public ProductionInterface Make()
    {
        return this;
    }

    public string Check()
    {
        return "OK";
    }
}
```

接下來製作Apple外觀器來讓作業員方便使用。

```C#
class AppleFacade
{
    public static string MakeApplePhone()
    {
        var apple = new Apple();

        return apple.Set().Make().Check();
    }
}
```

最後來請作業員使用

```C#
static void Main(string[] args)
{
    var apple = AppleFacade.MakeApplePhone();
}
```

這下子，作業員就不需要知道完整生產流程。

