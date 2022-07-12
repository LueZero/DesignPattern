# 裝飾者模式 Decorator Pattern

動態將類別添加額外的職責。就增加功能來說，裝飾者模式相比產生子類別更為靈活。

## 優點：

* 動態重用寫好的類別方法時，裝飾者可用組合去帶繼承的一種解決方案。
* 職責分明。

## 缺點：

* 複雜度提高。
* 方法不依賴執行順序時，無法使用此模式。

## 範例

> 蘋果公司製作的原廠手機，購買後會附贈掛件跟貼膜服務。

```C#
public class Apple
{
    public override void Print()
    {
        Console.WriteLine("蘋果公司確認可加工");
    }
}

public class Accessories : Apple
{
    public void AddAccessories()
    {
        Console.WriteLine("掛件");
    }

    public override void Print()
    {
        AddAccessories();
    }
}

public class Sticker : Apple
{
    public void AddSticker()
    {
        Console.WriteLine("貼膜");
    }

    public override void Print()
    {
        AddSticker();
    }
}

```

> 測試一下

```C#
public static void Main(string[] args)
{
    var apple = new Apple();
    var accessories = new Accessories();
    var sticker = new Sticker();

    accessories.Print();
    sticker.Print();
}
```

> 實現後會發現問題，裝飾者模式是要為了`減少`或`替代繼承`的使用，因為互相繼承的關係，會提高系統的耦合性，接著我們改寫方法。

```C#

* 手機抽象類，即裝飾者模式中的抽象元件類

public abstract class PhoneAbstract
{
    public abstract void Print();
}

* 重寫基類方法

public class Apple : PhoneAbstract
{
    public override void Print()
    {
        Console.WriteLine("蘋果公司確認可加工");
    }
}

*  裝飾抽象類，要讓裝飾完全取代抽象元件，所以必須繼承自Apple

public class Decorator : Apple
{
    private PhoneAbstract _phone;

    public Decorator(PhoneAbstract phone)
    {
        this._phone = phone;
    }

    public override void Print()
    {
        if (_phone != null)
        {
            _phone.Print();
        }
    }
}

*  新的行為方法

public class Accessories : Decorator
{
    public Accessories(PhoneAbstract phone) : base(phone)
    {
    }

    public override void Print()
    {
        base.Print();

        // 新增新的行為
        AddAccessories();
    }

    public void AddAccessories()
    {
        Console.WriteLine("現在蘋果手機有漂亮的掛件了");
    }
}

*  新的行為方法

public class Sticker : Decorator
{
    public Sticker(PhoneAbstract phone) : base(phone)
    {
    }

    public override void Print()
    {
        base.Print();

        // 新增新的行為
        AddSticker();
    }

    public void AddSticker()
    {
        Console.WriteLine("現在蘋果手機有貼膜了");
    }
}
```

> 測試結果

```C#
public static void Main(string[] args)
{
    // 我買了個蘋果手機
    Apple phone = new Apple();
    // 活動附贈貼膜
    Decorator applePhoneWithSticker = new Sticker(phone);
    // 另外附贈掛件
    Decorator applePhoneWithAccessories = new Accessories(applePhoneWithSticker);
    // 執行這些加值贈品
    applePhoneWithAccessories.Print();
}
```

以上為裝飾者模式範例，裝飾者模式專注在對象上，也就更能客製化需求。