# 工廠方法模式 Factory Method Pattern

工廠方法模式是簡單工廠模式的延伸議題，主要是不再提供統一的工廠類別來建立物件，而是將工廠類別抽象化，再去針對不同分類去製作不同的工廠。

## 優點：

* 物件的邏輯與物件本身的邏輯分離，一個工廠只會對應一個類別。

## 缺點：

* 會出現許多子類別，使代碼變得複雜，須使用另一種抽象工廠介面。

## 範例

> 一樣是批發需求。當公司越來越厲害，老闆想增加耳機產品來繼續擴大事業。

此時你會發現，原本的簡單手機工廠，從一開始都是手機，到耳機加入後你會發現邏輯變得越來越複雜。且常常會碰觸到開放封閉原則問題，所以我們可以使用工廠方法模式來處理此問題。

```C#

* 先定義產品工廠介面

public abstract class ProductFactory
{
    public abstract ProductInterface CreateProduct();
}

* 實作蘋果/三星工廠

public class AppleFactory : ProductFactory
{
    public override ProductInterface CreateProduct()
    {
        return new ApplePhone();
    }
}

public class SamsungFactory : ProductFactory
{
    public override ProductInterface CreateProduct()
    {
        return new SamsungPhone();
    }
}

* 加入Beats工廠

public class BeatsFactory : ProductFactory
{
    public override ProductInterface CreateProduct()
    {
        return new BeatsHeadphones();
    }
}

* 接著將手機類別修改成產品類別

public class Product {

    private static ProductFactory CreateProductFactory(string brand)
    {
        ProductFactory model = null;

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
```

> 測試結果

```C#
* 最後員工可以輸入品牌來開始批發產品

public static void Main(string[] args)
{
    var modelFactory = Product.CreateProductFactory("Apple");

    var product = modelFactory.CreateProduct();

    product.Wholesale();
}
```

以上為工廠方法模式範例，是非常遵守開放封閉原則，當新增產品時，僅需要新增產品類別以及創建類別。當修改原本產品時，只需要修改產品類別，不會去影響其他產品類別。
