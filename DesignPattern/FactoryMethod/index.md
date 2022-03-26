# 工廠方法模式 Factory Method Pattern

工廠方法模式是簡單工廠的延伸議題，主要是不再提供統一的工廠類別來建立物件，而是將工廠類別抽象化，再去針對不同分類去製作不同的工廠。

## 優點：
* 單一職責原則。你可以將產品創建代碼放在程序的單一位置， 從而使得代碼更容易維護。
* 開閉原則。無需更改現有客戶端代碼， 你就可以在程序中引入新的產品類型。

## 缺點：
* 會出現許多子類別，使代碼變得複雜。

## 範例

> 一樣是批發公司需求。當公司越來越厲害，老闆想增加耳機產品來繼續擴大事業。

此時你會發現，原本的簡單手機工廠，從一開始都是手機，到耳機邏輯越來越複雜。常常會碰觸到開放封閉原則，所以我們可以使用工廠方法來處理此問題。

```C#

* 先定義產品工廠介面

public abstract class ProductFactory
{
    public abstract ProductInterface CreateModel();
}

* 實作蘋果/三星手機工廠

public class AppleFactory : ProductFactory
{
    public override ProductInterface CreateModel()
    {
        return new ApplePhone();
    }
}

public class SamsungFactory : ProductFactory
{
    public override ProductInterface CreateModel()
    {
        return new SamsungPhone();
    }
}

* 加入耳機工廠

public class BeatsFactory : ProductFactory
{
    public override ProductInterface CreateModel()
    {
        return new BeatsHeadphones();
    }
}

* 接著將手機類別修改成產品類別

public class Product {

    private static ModelFactory CreateProduct(string brand)
    {
        ModelFactory model = null;

        switch(brand)
        {
            case "Apple":
                model = new AppleFactory();
                break;
            case "Samsung":
                model =  new SamsungFactory();
                break;
            case "Beats":
                model = new BeatsFactory();
                break;
        }

        return model;
    }

}

* 最後員工可以輸入品牌來批發各式各樣產品

static void Main(string[] args)
{
    var phone = Product.CreateProduct("apple");
}

```

以上為簡單工廠模式範例，是非常遵守開放封閉原則，當新增產品時，僅需要新增產品類別以及創建類別。當修改原本產品時，只需要修改產品類別，不會去影響其他產品類別。
