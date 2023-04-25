using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelationships.MostAccepted.EntityWuxingExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelationships.MostAccepted.EntityWuxingExtensions.Tests;

[TestClass()]
public class GuaWuxingExtensionsTests
{
    private static IEnumerable<Gua> QianDuiLiZhenXunKanGenKun()
    {
        yield return new Gua(Yinyang.Yang, Yinyang.Yang, Yinyang.Yang);
        yield return new Gua(Yinyang.Yang, Yinyang.Yang, Yinyang.Yin);
        yield return new Gua(Yinyang.Yang, Yinyang.Yin, Yinyang.Yang);
        yield return new Gua(Yinyang.Yang, Yinyang.Yin, Yinyang.Yin);
        yield return new Gua(Yinyang.Yin, Yinyang.Yang, Yinyang.Yang);
        yield return new Gua(Yinyang.Yin, Yinyang.Yang, Yinyang.Yin);
        yield return new Gua(Yinyang.Yin, Yinyang.Yin, Yinyang.Yang);
        yield return new Gua(Yinyang.Yin, Yinyang.Yin, Yinyang.Yin);
    }

    [TestMethod()]
    public void WuxingTest()
    {
        var wuxings = QianDuiLiZhenXunKanGenKun().Select((g) => g.Wuxing());
        Assert.IsTrue(wuxings.SequenceEqual(new[] {
            Wuxing.Metal,
            Wuxing.Metal,
            Wuxing.Fire,
            Wuxing.Wood,
            Wuxing.Wood,
            Wuxing.Water,
            Wuxing.Earth,
            Wuxing.Earth
        }));
    }

    [TestMethod()]
    public void WuxingTest1()
    {
        var wuxings = QianDuiLiZhenXunKanGenKun().Select((g) => g.As<GuaTrigram>().Wuxing());
        Assert.IsTrue(wuxings.SequenceEqual(new[] {
            Wuxing.Metal,
            Wuxing.Metal,
            Wuxing.Fire,
            Wuxing.Wood,
            Wuxing.Wood,
            Wuxing.Water,
            Wuxing.Earth,
            Wuxing.Earth
        }));
    }
}