using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelationships.MostAccepted.EntityYinyangExtensions.Tests;

[TestClass()]
public class TianganDizhiYinyangExtensionsTests
{
    [TestMethod()]
    public void YinyangTest()
    {
        Assert.AreEqual(Yinyang.Yang, Tiangan.Jia.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Yi.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Tiangan.Bing.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Ding.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Tiangan.Wu.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Ji.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Tiangan.Geng.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Xin.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Tiangan.Ren.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Gui.Yinyang());
    }

    [TestMethod()]
    public void YinyangByMod2Test()
    {
        Assert.AreEqual(Yinyang.Yang, Dizhi.Zi.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Chou.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Yin.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Mao.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Chen.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Si.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Wu.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Wei.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Shen.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yin, Dizhi.You.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Xu.YinyangByMod2());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Hai.YinyangByMod2());
    }
}