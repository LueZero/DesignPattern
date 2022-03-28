# 簡單工廠模式 Simple Factory Pattern

簡單工廠模式分別是工廠類別與產品類別，通常此模式中只會有一種工廠形式，負責一種產品建置。

## 優點：
* 符合單一職責原則。

## 缺點：
* 當新增、修改產品時，無法遵守開放封閉原則。

## 範例

> 假設你是一間手機批發公司，使用軟體去批發蘋果手機產品，如下類別

```C#

public class Phone {

    public void WholesaleApplePhone(string name)
    {
        Console.WriteLine("批發蘋果手機");
    }
}

```

>但突然有一天老闆想增加三星品牌手機進來。

```C#

public class Phone {

    public string WholesaleApplePhone(string name)
    {
        Console.WriteLine("批發蘋果手機");
    }

    public string WholesaleSamsungPhone(string name)
    {
        Console.WriteLine("批發三星手機");
    }
}

```

此時你會發現Phone類別會一直增加方法，且看起都是相同的事情。另外這樣修改會改變既有程式碼。也會違反開放封閉原則。接著我們將創造物件與物件本身任務分離。

Example :

```C#

* 定義產品的介面

public interface ProductInterface
{
    public void Wholesale();
}

* 實作蘋果手機

public class ApplePhone : ProductInterface
{
    public void Wholesale()
    {
        Console.WriteLine("批發蘋果手機");
    }
}

* 實作三星手機

public class SamsungPhone : ProductInterface
{
    public void Wholesale()
    {
        Console.WriteLine("批發三星手機");
    }
}

* 實作手機工廠

public static class PhoneFactory
{
    private static ProductInterface s_phone;

    public static ProductInterface CreatePhone(string brand)
    {
        switch (brand)
        {
            case "Apple":
                s_phone = new ApplePhone();
                break;

            case "Samsung":
                s_phone = new SamsungPhone();
                break;

            default:
                throw new Exception("missing matching brand name");
        }

        return s_phone;
    }
}

* 接著更改原本的程式

public class Phone {

    public static ProductInterface CreatePhone(string name)
    {
        return PhoneFactory.CreatePhone(name);
    }
}

* 最後員工可以輸入品牌來開始批發手機產品

static void Main(string[] args)
{
    var applePhone = Phone.CreatePhone("Apple");
    applePhone.Wholesale();
}
```

以上為簡單工廠模式範例，Phone類別減少了改變的機會，但創建產品類別依然常常需要變更。