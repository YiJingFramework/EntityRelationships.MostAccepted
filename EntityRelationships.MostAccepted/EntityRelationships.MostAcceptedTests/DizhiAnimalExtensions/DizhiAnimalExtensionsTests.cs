using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelationships.MostAccepted.DizhiAnimalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using System.Xml.Linq;
using YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;
using YiJingFramework.EntityRelationships.MostAccepted.Shared;

namespace YiJingFramework.EntityRelationships.MostAccepted.DizhiAnimalExtensions.Tests;

[TestClass()]
public class DizhiAnimalExtensionsTests
{
    [TestMethod()]
    public void AnimalTest()
    {
        Assert.AreEqual(ShengxiaoAnimal.Rat, Dizhi.Zi.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Cow, Dizhi.Chou.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Tiger, Dizhi.Yin.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Rabbit, Dizhi.Mao.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Long, Dizhi.Chen.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Snake, Dizhi.Si.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Horse, Dizhi.Wu.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Sheep, Dizhi.Wei.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Monkey, Dizhi.Shen.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Chicken, Dizhi.You.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Dog, Dizhi.Xu.Animal());
        Assert.AreEqual(ShengxiaoAnimal.Pig, Dizhi.Hai.Animal());
    }

    [TestMethod()]
    public void DizhiTest()
    {
        Assert.AreEqual(Dizhi.Zi, ShengxiaoAnimal.Rat.Dizhi());
        Assert.AreEqual(Dizhi.Chou, ShengxiaoAnimal.Cow.Dizhi());
        Assert.AreEqual(Dizhi.Yin, ShengxiaoAnimal.Tiger.Dizhi());
        Assert.AreEqual(Dizhi.Mao, ShengxiaoAnimal.Rabbit.Dizhi());
        Assert.AreEqual(Dizhi.Chen, ShengxiaoAnimal.Long.Dizhi());
        Assert.AreEqual(Dizhi.Si, ShengxiaoAnimal.Snake.Dizhi());
        Assert.AreEqual(Dizhi.Wu, ShengxiaoAnimal.Horse.Dizhi());
        Assert.AreEqual(Dizhi.Wei, ShengxiaoAnimal.Sheep.Dizhi());
        Assert.AreEqual(Dizhi.Shen, ShengxiaoAnimal.Monkey.Dizhi());
        Assert.AreEqual(Dizhi.You, ShengxiaoAnimal.Chicken.Dizhi());
        Assert.AreEqual(Dizhi.Xu, ShengxiaoAnimal.Dog.Dizhi());
        Assert.AreEqual(Dizhi.Hai, ShengxiaoAnimal.Pig.Dizhi());
    }

    [TestMethod()]
    public void ToStringTest()
    {
        ConversionToString<ShengxiaoAnimal>? conversion = null;
        Assert.AreEqual("Rat", ShengxiaoAnimal.Rat.ToString(conversion));
        Assert.AreEqual("Cow", ShengxiaoAnimal.Cow.ToString(conversion));
        Assert.AreEqual("Tiger", ShengxiaoAnimal.Tiger.ToString(conversion));
        Assert.AreEqual("Rabbit", ShengxiaoAnimal.Rabbit.ToString(conversion));
        Assert.AreEqual("Long", ShengxiaoAnimal.Long.ToString(conversion));
        Assert.AreEqual("Snake", ShengxiaoAnimal.Snake.ToString(conversion));
        Assert.AreEqual("Horse", ShengxiaoAnimal.Horse.ToString(conversion));
        Assert.AreEqual("Sheep", ShengxiaoAnimal.Sheep.ToString(conversion));
        Assert.AreEqual("Monkey", ShengxiaoAnimal.Monkey.ToString(conversion));
        Assert.AreEqual("Chicken", ShengxiaoAnimal.Chicken.ToString(conversion));
        Assert.AreEqual("Dog", ShengxiaoAnimal.Dog.ToString(conversion));
        Assert.AreEqual("Pig", ShengxiaoAnimal.Pig.ToString(conversion));
        Assert.AreEqual("100", ((ShengxiaoAnimal)100).ToString(conversion));
        
        conversion = ShengxiaoAnimalToStringConversions.InChinese;
        Assert.AreEqual("鼠", ShengxiaoAnimal.Rat.ToString(conversion));
        Assert.AreEqual("牛", ShengxiaoAnimal.Cow.ToString(conversion));
        Assert.AreEqual("虎", ShengxiaoAnimal.Tiger.ToString(conversion));
        Assert.AreEqual("兔", ShengxiaoAnimal.Rabbit.ToString(conversion));
        Assert.AreEqual("龙", ShengxiaoAnimal.Long.ToString(conversion));
        Assert.AreEqual("蛇", ShengxiaoAnimal.Snake.ToString(conversion));
        Assert.AreEqual("马", ShengxiaoAnimal.Horse.ToString(conversion));
        Assert.AreEqual("羊", ShengxiaoAnimal.Sheep.ToString(conversion));
        Assert.AreEqual("猴", ShengxiaoAnimal.Monkey.ToString(conversion));
        Assert.AreEqual("鸡", ShengxiaoAnimal.Chicken.ToString(conversion));
        Assert.AreEqual("狗", ShengxiaoAnimal.Dog.ToString(conversion));
        Assert.AreEqual("猪", ShengxiaoAnimal.Pig.ToString(conversion));
        Assert.AreEqual("100", ((ShengxiaoAnimal)100).ToString(conversion));
    }
}